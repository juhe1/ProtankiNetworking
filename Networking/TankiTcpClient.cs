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
    /// Handles TCP client for connecting to the ProTanki server and processing packets
    /// </summary>
    public abstract class TankiTcpClient
    {
        private readonly CProtection _protection;
        private readonly IPEndPoint _serverEndPoint;
        private CancellationTokenSource _cancellationTokenSource;
        private Task _processingTask;
        private TcpClient _client;
        private NetworkStream _stream;

        /// <summary>
        /// Creates a new instance of TankiTcpClient
        /// </summary>
        /// <param name="serverEndPoint">The server endpoint to connect to</param>
        /// <param name="protection">The protection instance for packet encryption/decryption</param>
        protected TankiTcpClient(
            IPEndPoint serverEndPoint,
            CProtection protection)
        {
            _serverEndPoint = serverEndPoint;
            _protection = protection;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        /// <summary>
        /// Called when a raw packet is received from the server, including header bytes
        /// </summary>
        /// <param name="rawPacket">The complete raw packet data including headers</param>
        protected abstract Task OnRawPacketReceivedAsync(byte[] rawPacket);

        /// <summary>
        /// Called when a packet is received from the server
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
        /// Sends a packet to the server
        /// </summary>
        /// <param name="packet">The packet to send</param>
        public async Task SendPacketAsync(AbstractPacket packet)
        {
            if (_stream == null || _client == null || !_client.Connected)
                return;

            try
            {
                var packetData = packet.Wrap(_protection);
                await _stream.WriteAsync(packetData.ToArray(), 0, packetData.Length);
                await _stream.FlushAsync();
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpClient.SendPacket");
            }
        }

        /// <summary>
        /// Sends raw packet data to the server
        /// </summary>
        /// <param name="rawData">The raw packet data to send</param>
        public async Task SendRawPacketAsync(byte[] rawData)
        {
            if (_stream == null || _client == null || !_client.Connected)
                return;

            try
            {
                await _stream.WriteAsync(rawData, 0, rawData.Length);
                await _stream.FlushAsync();
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpClient.SendRawPacket");
            }
        }

        /// <summary>
        /// Connects to the server and starts processing packets
        /// </summary>
        public async Task ConnectAsync()
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(_serverEndPoint.Address, _serverEndPoint.Port);
                _stream = _client.GetStream();
                _processingTask = ProcessPacketsAsync();
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpClient.Connect");
            }
        }

        /// <summary>
        /// Disconnects from the server
        /// </summary>
        public async Task DisconnectAsync()
        {
            _cancellationTokenSource.Cancel();

            if (_stream != null)
            {
                _stream.Close();
                _stream = null;
            }

            if (_client != null)
            {
                _client.Close();
                _client = null;
            }

            if (_processingTask != null)
            {
                try
                {
                    await _processingTask;
                }
                catch (OperationCanceledException)
                {
                    // Expected when cancelling
                }
            }
        }

        /// <summary>
        /// Main loop for processing packets from the server
        /// </summary>
        private async Task ProcessPacketsAsync()
        {
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    // Read header bytes
                    var packetLenBytes = new byte[4];
                    var packetIdBytes = new byte[4];
                    await _stream.ReadExactlyAsync(packetLenBytes, 0, 4);
                    await _stream.ReadExactlyAsync(packetIdBytes, 0, 4);

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
                        await _stream.ReadExactlyAsync(rawPacket, 8, packetDataLen);
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
            catch (OperationCanceledException)
            {
                // Expected when cancelling
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpClient.ProcessPackets");
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