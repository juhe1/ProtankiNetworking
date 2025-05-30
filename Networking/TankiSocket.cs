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
    /// Handles network communication with the ProboTanki server
    /// </summary>
    public class TankiSocket
    {
        /// <summary>
        /// The server endpoint
        /// </summary>
        public static readonly IPEndPoint ENDPOINT = new IPEndPoint(IPAddress.Parse("146.59.110.146"), 25565); // core-protanki.com

        private readonly CProtection _protection;
        private readonly IPEndPoint _proxy;
        private readonly ManualResetEvent _emergencyHalt;
        private readonly Action<AbstractPacket> _onDataReceived;
        private readonly Action<Exception, string, string> _onSocketClose;
        private Socket _socket;
        private readonly Thread _thread;

        /// <summary>
        /// Creates a new instance of TankiSocket
        /// </summary>
        /// <param name="protection">The protection instance for packet encryption/decryption</param>
        /// <param name="proxy">Optional proxy endpoint</param>
        /// <param name="emergencyHalt">Event to signal emergency halt</param>
        /// <param name="onDataReceived">Callback for received packets</param>
        /// <param name="onSocketClose">Callback for socket closure</param>
        /// <param name="socket">Optional existing socket to use</param>
        public TankiSocket(
            CProtection protection,
            IPEndPoint proxy = null,
            ManualResetEvent emergencyHalt = null,
            Action<AbstractPacket> onDataReceived = null,
            Action<Exception, string, string> onSocketClose = null,
            Socket socket = null)
        {
            _protection = protection;
            _proxy = proxy;
            _emergencyHalt = emergencyHalt ?? new ManualResetEvent(false);
            _onDataReceived = onDataReceived;
            _onSocketClose = onSocketClose;

            if (socket == null)
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _socket.ReceiveTimeout = 15000;
                _socket.SendTimeout = 15000;
            }
            else
            {
                _socket = socket;
            }

            _thread = new Thread(Loop) { IsBackground = false };
            _thread.Start();
        }

        /// <summary>
        /// Establishes connection to the endpoint with retry and backoff
        /// </summary>
        /// <returns>True if connection was successful</returns>
        public bool Connect()
        {
            const int maxRetries = 3;
            const int retryDelay = 2; // Start with 2 seconds

            for (int attempt = 0; attempt < maxRetries; attempt++)
            {
                try
                {
                    // If already connected, skip reconnection
                    if (_socket.Connected)
                        return true;

                    // Create a new socket for each attempt to avoid stale resources
                    if (attempt > 0)
                    {
                        _socket.Close();
                        _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        _socket.ReceiveTimeout = 15000;
                        _socket.SendTimeout = 15000;
                    }

                    _socket.Connect(ENDPOINT);
                    return true;
                }
                catch (SocketException e)
                {
                    // Proxy timeout - use exponential backoff
                    if (attempt < maxRetries - 1)
                    {
                        int backoffTime = retryDelay * (int)Math.Pow(2, attempt);
                        Thread.Sleep(backoffTime);
                    }
                    else
                    {
                        _onSocketClose?.Invoke(e, "TankiSocket.Connect", $"Not Connected | Proxy: {_proxy}");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    _onSocketClose?.Invoke(e, "TankiSocket.Connect", $"Not Connected | Proxy: {_proxy}");
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Reads packet header from socket
        /// </summary>
        /// <returns>Tuple containing packet length and ID</returns>
        private (int length, int id) ReadPacketHeader()
        {
            var packetLenBytes = new byte[4];
            var packetIdBytes = new byte[4];

            int bytesRead = _socket.Receive(packetLenBytes);
            if (bytesRead == 0)
                throw new Exception("Socket Pipe Broken");

            bytesRead = _socket.Receive(packetIdBytes);
            if (bytesRead == 0)
                throw new Exception("Socket Pipe Broken");

            var packetLen = BitConverter.ToInt32(packetLenBytes, 0);
            var packetId = BitConverter.ToInt32(packetIdBytes, 0);

            return (packetLen, packetId);
        }

        /// <summary>
        /// Loads chunked data into the socket buffer until we have all the data to read
        /// </summary>
        /// <param name="dataLen">Length of data to read</param>
        /// <returns>ByteArray containing the read data</returns>
        private EByteArray ReadPacketData(int dataLen)
        {
            var encryptedData = new EByteArray();
            var buffer = new byte[dataLen];
            int totalBytesRead = 0;

            while (totalBytesRead < dataLen)
            {
                int bytesRead = _socket.Receive(buffer, totalBytesRead, dataLen - totalBytesRead, SocketFlags.None);
                if (bytesRead == 0)
                    throw new Exception("Socket Pipe Broken");

                totalBytesRead += bytesRead;
            }

            encryptedData.Write(buffer);
            return encryptedData;
        }

        /// <summary>
        /// Processes received packet data
        /// </summary>
        /// <param name="packetId">ID of the received packet</param>
        /// <param name="encryptedData">Encrypted packet data</param>
        private void ProcessPacket(int packetId, EByteArray encryptedData)
        {
            var packetData = _protection.Decrypt(encryptedData.ToArray());
            var fittedPacket = PacketFitter(packetId, new EByteArray(packetData));
            _onDataReceived?.Invoke(fittedPacket);
        }

        /// <summary>
        /// Main socket loop
        /// </summary>
        private void Loop()
        {
            if (!Connect())
                return;

            while (!_emergencyHalt.WaitOne(0))
            {
                try
                {
                    var (packetLen, packetId) = ReadPacketHeader();
                    int packetDataLen = packetLen - AbstractPacket.HEADER_LEN;

                    EByteArray encryptedData;
                    if (packetDataLen > 0)
                        encryptedData = ReadPacketData(packetDataLen);
                    else
                        encryptedData = new EByteArray();

                    ProcessPacket(packetId, encryptedData);
                }
                catch (Exception e)
                {
                    _onSocketClose?.Invoke(e, "TankiSocket.Loop", "Socket Loop Error");
                    break;
                }
            }
        }

        /// <summary>
        /// Fits packet data into a packet object
        /// </summary>
        /// <param name="packetId">ID of the packet</param>
        /// <param name="packetData">Raw packet data</param>
        /// <returns>Fitted packet object</returns>
        private AbstractPacket PacketFitter(int packetId, EByteArray packetData)
        {
            var packetType = PacketManager.GetPacketById(packetId);
            if (packetType == null)
            {
                var packet = new AbstractPacket();
                packet.Id = packetId;
                packet.Objects.Add(packetData);
                packet.Object["data"] = packetData;
                return packet;
            }

            var currentPacket = (AbstractPacket)Activator.CreateInstance(packetType);
            currentPacket.Unwrap(packetData);
            return currentPacket;
        }

        /// <summary>
        /// Closes the socket connection
        /// </summary>
        public void CloseSocket()
        {
            _socket.Close();
        }

        /// <summary>
        /// Sends data through the socket
        /// </summary>
        /// <param name="data">The data to send</param>
        public void Send(byte[] data)
        {
            try
            {
                _socket.Send(data);
            }
            catch (Exception e)
            {
                _onSocketClose?.Invoke(e, "TankiSocket.Send", "Failed to send data");
            }
        }

        /// <summary>
        /// Handles socket closure
        /// </summary>
        /// <param name="exception">The exception that caused the closure</param>
        /// <param name="source">The source of the closure</param>
        /// <param name="details">Additional details about the closure</param>
        /// <param name="logError">Whether to log the error</param>
        /// <param name="addToReconnections">Whether to add to reconnection history</param>
        /// <param name="killInstance">Whether to kill the instance</param>
        public void OnSocketClose(Exception exception, string source, string details, bool logError = true, bool addToReconnections = true, bool killInstance = false)
        {
            _onSocketClose?.Invoke(exception, source, details);
        }
    }
} 