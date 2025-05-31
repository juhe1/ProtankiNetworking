using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using ProboTankiLibCS.Packets;
using ProboTankiLibCS.Security;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Networking
{
    /// <summary>
    /// Handles a single TCP client connection for the ProTanki proxy
    /// </summary>
    public abstract class TankiTcpClientHandler
    {
        private readonly TcpClient _client;
        private readonly CProtection _protection;
        private readonly CancellationToken _cancellationToken;
        private NetworkStream _stream;

        protected TankiTcpClientHandler(TcpClient client, CProtection protection, CancellationToken cancellationToken)
        {
            _client = client;
            _protection = protection;
            _cancellationToken = cancellationToken;
        }

        public async Task StartAsync()
        {
            try
            {
                _stream = _client.GetStream();
                while (!_cancellationToken.IsCancellationRequested)
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
                await OnErrorAsync(e, "TankiTcpClientHandler.StartAsync");
            }
            finally
            {
                _stream = null;
                _client.Close();
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

        protected abstract Task OnRawPacketReceivedAsync(byte[] rawPacket);
        protected abstract Task OnPacketReceivedAsync(AbstractPacket packet);
        protected abstract Task OnErrorAsync(Exception exception, string context);
    }
} 