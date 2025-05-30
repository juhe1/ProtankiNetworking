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
    /// Handles asynchronous network communication with the ProboTanki server
    /// </summary>
    public class AsyncTankiSocket
    {
        /// <summary>
        /// The server endpoint
        /// </summary>
        public static readonly IPEndPoint ENDPOINT = new IPEndPoint(IPAddress.Parse("146.59.110.146"), 25565); // core-protanki.com

        private const int SOCKET_RETRY_DELAY = 2; // seconds
        private const int SOCKET_MAX_RETRIES = 3; // max retries for connection

        private readonly CProtection _protection;
        private readonly IPEndPoint _proxy;
        private readonly AsyncManualResetEvent _emergencyHalt;
        private readonly Func<AbstractPacket, Task> _onDataReceived;
        private readonly Func<Exception, string, string, Task> _onSocketClose;
        private TcpClient _client;
        private NetworkStream _stream;
        private Task _processingTask;
        private CancellationTokenSource _cancellationTokenSource;

        /// <summary>
        /// Creates a new instance of AsyncTankiSocket
        /// </summary>
        /// <param name="protection">The protection instance for packet encryption/decryption</param>
        /// <param name="proxy">Optional proxy endpoint</param>
        /// <param name="emergencyHalt">Event to signal emergency halt</param>
        /// <param name="onDataReceived">Callback for received packets</param>
        /// <param name="onSocketClose">Callback for socket closure</param>
        public AsyncTankiSocket(
            CProtection protection,
            IPEndPoint proxy = null,
            AsyncManualResetEvent emergencyHalt = null,
            Func<AbstractPacket, Task> onDataReceived = null,
            Func<Exception, string, string, Task> onSocketClose = null)
        {
            _protection = protection;
            _proxy = proxy;
            _emergencyHalt = emergencyHalt ?? new AsyncManualResetEvent(false);
            _onDataReceived = onDataReceived;
            _onSocketClose = onSocketClose;
            _cancellationTokenSource = new CancellationTokenSource();

            // Start socket processing task
            _processingTask = ProcessSocketAsync();
        }

        /// <summary>
        /// Main socket processing loop
        /// </summary>
        private async Task ProcessSocketAsync()
        {
            try
            {
                if (!await ConnectAsync())
                    return;

                while (!_emergencyHalt.IsSet)
                {
                    int packetLen = 0;
                    int packetId = 0;
                    try
                    {
                        var (len, id) = await ReadPacketHeaderAsync();
                        packetLen = len;
                        packetId = id;
                        int packetDataLen = packetLen - AbstractPacket.HEADER_LEN;

                        ByteArray encryptedData;
                        if (packetDataLen > 0)
                            encryptedData = await ReadPacketDataAsync(packetDataLen);
                        else
                            encryptedData = new ByteArray();

                        await ProcessPacketAsync(packetId, encryptedData);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                    catch (Exception e)
                    {
                        string state = $"Connected | Packet Length: {packetLen} | Packet ID: {packetId}";
                        await _onSocketClose?.Invoke(e, "AsyncTankiSocket.ProcessSocket", state);
                        break;
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Task was cancelled, clean up
                await CloseSocketAsync();
            }
        }

        /// <summary>
        /// Establishes connection to the endpoint with retry and backoff
        /// </summary>
        /// <returns>True if connection was successful</returns>
        private async Task<bool> ConnectAsync()
        {
            for (int attempt = 0; attempt < SOCKET_MAX_RETRIES; attempt++)
            {
                try
                {
                    // Check if already connected
                    if (_client?.Connected == true)
                        return true;

                    // Close existing connection if any
                    if (_client != null)
                    {
                        _client.Close();
                        _client = null;
                    }

                    if (_proxy != null)
                    {
                        // TODO: Implement proxy support
                        throw new NotImplementedException("Proxy support not implemented yet");
                    }
                    else
                    {
                        // Direct connection
                        _client = new TcpClient();
                        await _client.ConnectAsync(ENDPOINT.Address, ENDPOINT.Port);
                        _stream = _client.GetStream();
                    }

                    return true;
                }
                catch (SocketException e)
                {
                    if (attempt < SOCKET_MAX_RETRIES - 1)
                    {
                        // Exponential backoff
                        int backoffTime = SOCKET_RETRY_DELAY * (int)Math.Pow(2, attempt);
                        await Task.Delay(backoffTime * 1000);
                    }
                    else
                    {
                        await _onSocketClose?.Invoke(e, "AsyncTankiSocket.Connect", $"Not Connected | Proxy: {_proxy}");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    if (attempt < SOCKET_MAX_RETRIES - 1)
                    {
                        // Exponential backoff
                        int backoffTime = SOCKET_RETRY_DELAY * (int)Math.Pow(2, attempt);
                        await Task.Delay(backoffTime * 1000);
                    }
                    else
                    {
                        await _onSocketClose?.Invoke(e, "AsyncTankiSocket.Connect", $"Not Connected | Proxy: {_proxy}");
                        return false;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Reads packet header asynchronously
        /// </summary>
        /// <returns>Tuple containing packet length and ID</returns>
        private async Task<(int length, int id)> ReadPacketHeaderAsync()
        {
            if (_stream == null)
                throw new InvalidOperationException("Not connected");

            var packetLenBytes = new byte[4];
            var packetIdBytes = new byte[4];

            await _stream.ReadExactlyAsync(packetLenBytes, 0, 4);
            await _stream.ReadExactlyAsync(packetIdBytes, 0, 4);

            var packetLen = BitConverter.ToInt32(packetLenBytes, 0);
            var packetId = BitConverter.ToInt32(packetIdBytes, 0);

            return (packetLen, packetId);
        }

        /// <summary>
        /// Reads packet data asynchronously
        /// </summary>
        /// <param name="dataLen">Length of data to read</param>
        /// <returns>ByteArray containing the read data</returns>
        private async Task<ByteArray> ReadPacketDataAsync(int dataLen)
        {
            if (_stream == null)
                throw new InvalidOperationException("Not connected");

            var buffer = new byte[dataLen];
            await _stream.ReadExactlyAsync(buffer, 0, dataLen);

            var encryptedData = new ByteArray();
            encryptedData.Write(buffer);
            return encryptedData;
        }

        /// <summary>
        /// Processes received packet data
        /// </summary>
        /// <param name="packetId">ID of the received packet</param>
        /// <param name="encryptedData">Encrypted packet data</param>
        private async Task ProcessPacketAsync(int packetId, ByteArray encryptedData)
        {
            var packetData = _protection.Decrypt(encryptedData.ToArray());
            var fittedPacket = PacketFitter(packetId, new ByteArray(packetData));
            await _onDataReceived?.Invoke(fittedPacket);
        }

        /// <summary>
        /// Fits received data into appropriate packet type
        /// </summary>
        /// <param name="packetId">ID of the packet</param>
        /// <param name="packetData">Packet data</param>
        /// <returns>Fitted packet instance</returns>
        private AbstractPacket PacketFitter(int packetId, ByteArray packetData)
        {
            var packetType = PacketManager.GetPacketById(packetId);
            if (packetType == null)
            {
                var packet = new AbstractPacket();
                packet.Objects.Add(packetData);
                packet.Object["data"] = packetData;
                return packet;
            }

            var currentPacket = (AbstractPacket)Activator.CreateInstance(packetType);
            currentPacket.Unwrap(new EByteArray(packetData.ToArray()));
            return currentPacket;
        }

        /// <summary>
        /// Sends packet data asynchronously
        /// </summary>
        /// <param name="packetData">Data to send</param>
        public async Task SendAsync(ByteArray packetData)
        {
            if (_stream == null || !_client.Connected)
                return;

            if (!_emergencyHalt.IsSet)
            {
                try
                {
                    await _stream.WriteAsync(packetData.ToArray(), 0, packetData.Length);
                    await _stream.FlushAsync();
                }
                catch
                {
                    _stream = null;
                }
            }
        }

        /// <summary>
        /// Closes the socket connection
        /// </summary>
        public async Task CloseSocketAsync()
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

            // Wait for processing task to complete
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
} 