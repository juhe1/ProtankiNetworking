using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Security;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Networking
{
    /// <summary>
    /// Handles a single TCP client connection for the TankiTcpListener
    /// </summary>
    public abstract class TankiTcpClientHandler
    {
        protected readonly TcpClient _client;
        private readonly CProtection _protection;
        protected readonly CancellationToken _cancellationToken;
        private NetworkStream _stream;

        protected TankiTcpClientHandler(TcpClient client, CProtection protection, CancellationToken cancellationToken)
        {
            _client = client;
            _protection = protection;
            _cancellationToken = cancellationToken;
        }

        protected CProtection Protection => _protection;

        public async Task StartAsync()
        {
            try
            {
                _stream = _client.GetStream();
                await OnConnectedAsync();
                
                while (!_cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        // Read header bytes
                        var packetLenBytes = new byte[4];
                        var packetIdBytes = new byte[4];
                        
                        // Check if connection is closed
                        int bytesRead = await _stream.ReadAsync(packetLenBytes, 0, 4);
                        if (bytesRead == 0)
                        {
                            // Connection closed by client
                            break;
                        }
                        
                        bytesRead = await _stream.ReadAsync(packetIdBytes, 0, 4);
                        if (bytesRead == 0)
                        {
                            // Connection closed by client
                            break;
                        }

                        // Create complete raw packet buffer first with original byte order
                        var rawPacket = new byte[8];
                        Buffer.BlockCopy(packetLenBytes, 0, rawPacket, 0, 4);
                        Buffer.BlockCopy(packetIdBytes, 0, rawPacket, 4, 4);

                        // Convert from big-endian to little-endian for BitConverter
                        Array.Reverse(packetLenBytes);
                        Array.Reverse(packetIdBytes);
                        var packetLen = BitConverter.ToInt32(packetLenBytes, 0);
                        var packetId = BitConverter.ToInt32(packetIdBytes, 0);
                        int packetDataLen = packetLen - AbstractPacket.HEADER_LEN;

                        // Validate packet length
                        if (packetLen < AbstractPacket.HEADER_LEN || packetLen > 1024 * 1024) // Max 1MB packet size
                        {
                            throw new InvalidOperationException($"Invalid packet length: {packetLen}");
                        }

                        // Resize raw packet to full length if needed
                        if (packetLen > 8)
                        {
                            Array.Resize(ref rawPacket, packetLen);
                        }

                        // Read packet data if any
                        if (packetDataLen > 0)
                        {
                            bytesRead = await _stream.ReadAsync(rawPacket, 8, packetDataLen);
                            if (bytesRead == 0)
                            {
                                // Connection closed by client
                                break;
                            }
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
                    catch (IOException ex) when (ex.InnerException is SocketException socketEx && 
                        (socketEx.SocketErrorCode == SocketError.ConnectionReset || 
                         socketEx.SocketErrorCode == SocketError.ConnectionAborted ||
                         socketEx.SocketErrorCode == SocketError.OperationAborted))
                    {
                        // Connection was closed by the remote end
                        break;
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Expected when cancelling
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpClientHandler.StartAsync");
            }
            finally
            {
                _stream = null;
                _client.Close();
                await OnDisconnectedAsync();
            }
        }

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
                await OnErrorAsync(e, "TankiTcpClientHandler.SendPacket");
            }
        }

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
                await OnErrorAsync(e, "TankiTcpClientHandler.SendRawPacket");
            }
        }

        private async Task ProcessPacketAsync(int packetId, ByteArray encryptedData)
        {
            var packetData = _protection.Decrypt(encryptedData.ToArray());
            var fittedPacket = PacketFitter(packetId, new ByteArray(packetData));
            await OnPacketReceivedAsync(fittedPacket);
        }

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

        /// <summary>
        /// Called when the client connects
        /// </summary>
        protected abstract Task OnConnectedAsync();

        /// <summary>
        /// Called when a raw packet is received from the client
        /// </summary>
        /// <param name="rawPacket">The complete raw packet data including headers</param>
        protected abstract Task OnRawPacketReceivedAsync(byte[] rawPacket);

        /// <summary>
        /// Called when a packet is received from the client
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
        /// Called when the client disconnects
        /// </summary>
        protected abstract Task OnDisconnectedAsync();
    }
} 