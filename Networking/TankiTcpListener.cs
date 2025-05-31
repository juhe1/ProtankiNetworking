using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using ProboTankiLibCS.Packets;
using ProboTankiLibCS.Security;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Networking
{
    /// <summary>
    /// Handles TCP listener for accepting client connections and processing their packets
    /// </summary>
    public abstract class TankiTcpListener
    {
        private readonly TcpListener _listener;
        private readonly CProtection _protection;
        private CancellationTokenSource _cancellationTokenSource;
        private Task _acceptClientsTask;
        private TcpClient _currentClient;
        private NetworkStream _currentStream;

        /// <summary>
        /// Creates a new instance of TankiTcpListener
        /// </summary>
        /// <param name="localEndPoint">The local endpoint to listen on</param>
        /// <param name="protection">The protection instance for packet encryption/decryption</param>
        protected TankiTcpListener(
            IPEndPoint localEndPoint,
            CProtection protection)
        {
            _listener = new TcpListener(localEndPoint);
            _protection = protection;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        /// <summary>
        /// Called when a raw packet is received from a client, including header bytes
        /// </summary>
        /// <param name="rawPacket">The complete raw packet data including headers</param>
        protected abstract Task OnRawPacketReceivedAsync(byte[] rawPacket);

        /// <summary>
        /// Called when a packet is received from a client
        /// </summary>
        /// <param name="packet">The received packet</param>
        protected abstract Task OnPacketReceivedAsync(AbstractPacket packet);

        /// <summary>
        /// Called when an error occurs
        /// </summary>
        /// <param name="exception">The exception that occurred</param>
        /// <param name="context">The context where the error occurred</param>
        protected abstract Task OnErrorAsync(Exception exception, string context);

        /// <summary>
        /// Sends a packet to the connected client
        /// </summary>
        /// <param name="packet">The packet to send</param>
        public async Task SendPacketAsync(AbstractPacket packet)
        {
            if (_currentStream == null || _currentClient == null || !_currentClient.Connected)
                return;

            try
            {
                var packetData = packet.Wrap(_protection);
                await _currentStream.WriteAsync(packetData.ToArray(), 0, packetData.Length);
                await _currentStream.FlushAsync();
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpListener.SendPacket");
            }
        }

        /// <summary>
        /// Sends raw packet data to the connected client
        /// </summary>
        /// <param name="rawData">The raw packet data to send</param>
        public async Task SendRawPacketAsync(byte[] rawData)
        {
            if (_currentStream == null || _currentClient == null || !_currentClient.Connected)
                return;

            try
            {
                await _currentStream.WriteAsync(rawData, 0, rawData.Length);
                await _currentStream.FlushAsync();
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpListener.SendRawPacket");
            }
        }

        /// <summary>
        /// Starts listening for client connections
        /// </summary>
        public void Start()
        {
            _listener.Start();
            _acceptClientsTask = AcceptClientsAsync();
        }

        /// <summary>
        /// Stops listening for client connections
        /// </summary>
        public async Task StopAsync()
        {
            _cancellationTokenSource.Cancel();
            _listener.Stop();

            if (_acceptClientsTask != null)
            {
                try
                {
                    await _acceptClientsTask;
                }
                catch (OperationCanceledException)
                {
                    // Expected when cancelling
                }
            }
        }

        /// <summary>
        /// Main loop for accepting client connections
        /// </summary>
        private async Task AcceptClientsAsync()
        {
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    _ = HandleClientAsync(client);
                }
            }
            catch (OperationCanceledException)
            {
                // Expected when cancelling
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpListener.AcceptClients");
            }
        }

        /// <summary>
        /// Handles a single client connection
        /// </summary>
        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                _currentClient = client;
                using (_currentStream = client.GetStream())
                {
                    while (!_cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        // Read header bytes
                        var packetLenBytes = new byte[4];
                        var packetIdBytes = new byte[4];
                        await _currentStream.ReadExactlyAsync(packetLenBytes, 0, 4);
                        await _currentStream.ReadExactlyAsync(packetIdBytes, 0, 4);

                        var packetLen = BitConverter.ToInt32(packetLenBytes, 0);
                        var packetId = BitConverter.ToInt32(packetIdBytes, 0);
                        int packetDataLen = packetLen - AbstractPacket.HEADER_LEN;

                        // Create complete raw packet buffer
                        var rawPacket = new byte[packetLen];
                        Buffer.BlockCopy(packetLenBytes, 0, rawPacket, 0, 4);
                        Buffer.BlockCopy(packetIdBytes, 0, rawPacket, 4, 4);

                        // Read packet data if any
                        if (packetDataLen > 0)
                        {
                            await _currentStream.ReadExactlyAsync(rawPacket, 8, packetDataLen);
                        }

                        // Notify about raw packet first
                        await OnRawPacketReceivedAsync(rawPacket);

                        // Then process the packet normally
                        var encryptedData = new ByteArray();
                        if (packetDataLen > 0)
                        {
                            var packetData = new byte[packetDataLen];
                            Buffer.BlockCopy(rawPacket, 8, packetData, 0, packetDataLen);
                            encryptedData.Write(packetData);
                        }
                        await ProcessPacketAsync(packetId, encryptedData);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Expected when cancelling
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpListener.HandleClient");
            }
            finally
            {
                _currentStream = null;
                _currentClient = null;
                client.Close();
            }
        }

        /// <summary>
        /// Processes received packet data
        /// </summary>
        private async Task ProcessPacketAsync(int packetId, ByteArray encryptedData)
        {
            var packetData = _protection.Decrypt(encryptedData.ToArray());
            var fittedPacket = PacketFitter(packetId, new ByteArray(packetData));
            await OnPacketReceivedAsync(fittedPacket);
        }

        /// <summary>
        /// Fits received data into appropriate packet type
        /// </summary>
        private AbstractPacket PacketFitter(int packetId, ByteArray packetData)
        {
            var packetType = PacketManager.GetPacketById(packetId);
            if (packetType == null)
            {
                var packet = new UnknownPacket();
                packet.Id = packetId;
                packet.Objects[0] = packetData;
                return packet;
            }

            var currentPacket = (AbstractPacket)Activator.CreateInstance(packetType);
            currentPacket.Unwrap(new EByteArray(packetData.ToArray()));
            return currentPacket;
        }
    }
} 