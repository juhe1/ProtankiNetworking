using System.Net;
using System.Net.Sockets;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Packets.Network;
using ProtankiNetworking.Security;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Networking;

/// <summary>
///     Handles TCP client for connecting to the ProTanki server and processing packets
/// </summary>
public abstract class TankiTcpClient
{
    private readonly Protection _protection;
    private readonly IPEndPoint _serverEndPoint;
    private CancellationTokenSource _cancellationTokenSource;
    private TcpClient? _client;
    private Task? _processingTask;
    private NetworkStream? _stream;

    /// <summary>
    ///     Creates a new instance of TankiTcpClient
    /// </summary>
    /// <param name="serverEndPoint">The server endpoint to connect to</param>
    /// <param name="protection">The protection instance for packet encryption/decryption</param>
    protected TankiTcpClient(IPEndPoint serverEndPoint, Protection protection)
    {
        _serverEndPoint = serverEndPoint;
        _protection = protection;
        _cancellationTokenSource = new CancellationTokenSource();
    }

    /// <summary>
    ///     Called when a raw packet is received from the server, including header bytes
    /// </summary>
    /// <param name="rawPacket">The complete raw packet data including headers</param>
    protected abstract Task OnRawPacketReceivedAsync(byte[] rawPacket);

    /// <summary>
    ///     Called when a packet is received from the server
    /// </summary>
    /// <param name="packet">The received packet</param>
    protected abstract Task OnPacketReceivedAsync(AbstractPacket packet);

    /// <summary>
    ///     Called when an error occurs
    /// </summary>
    /// <param name="exception">The exception that occurred</param>
    /// <param name="context">The context where the error occurred</param>
    protected abstract Task OnErrorAsync(Exception exception, string context);

    /// <summary>
    ///     Called when connected to the server
    /// </summary>
    protected abstract Task OnConnectedAsync();

    /// <summary>
    ///     Called when disconnected from the server
    /// </summary>
    protected abstract Task OnDisconnectedAsync();

    /// <summary>
    ///     Called when a packet fails to unwrap
    /// </summary>
    /// <param name="packetType">The type of packet that failed</param>
    /// <param name="packetId">The ID of the packet that failed</param>
    /// <param name="exception">The exception that occurred during unwrapping</param>
    protected abstract Task OnPacketUnwrapFailureAsync(
        Type packetType,
        int packetId,
        Exception exception
    );

    /// <summary>
    ///     Sends a packet to the server
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
    ///     Sends raw packet data to the server
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
    ///     Connects to the server and starts processing packets
    /// </summary>
    public async Task ConnectAsync()
    {
        try
        {
            _client = new TcpClient();
            await _client.ConnectAsync(_serverEndPoint.Address, _serverEndPoint.Port);
            _stream = _client.GetStream();
            _processingTask = Task.Run(ProcessPacketsAsync);
            await OnConnectedAsync();
        }
        catch (Exception e)
        {
            await OnErrorAsync(e, "TankiTcpClient.Connect");
        }
    }

    /// <summary>
    ///     Disconnects from the server
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
            try
            {
                await _processingTask;
            }
            catch (OperationCanceledException)
            {
                // Expected when cancelling
            }

        await OnDisconnectedAsync();
    }

    /// <summary>
    ///     Main loop for processing packets from the server
    /// </summary>
    private async Task ProcessPacketsAsync()
    {
        try
        {
            while (!_cancellationTokenSource.Token.IsCancellationRequested)
                try
                {
                    // Read header bytes
                    var packetLenBytes = new byte[4];
                    var packetIdBytes = new byte[4];
                    if (_stream is null)
                    {
                        throw new Exception("_stream cannot be null");
                    }
                    await _stream.ReadExactlyAsync(packetLenBytes, 0, 4);
                    await _stream.ReadExactlyAsync(packetIdBytes, 0, 4);

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
                        throw new InvalidOperationException($"Invalid packet length: {packetLen}");

                    // Resize raw packet to full length if needed
                    if (packetLen > 8)
                        Array.Resize(ref rawPacket, packetLen);

                    // Read packet data if any
                    if (packetDataLen > 0)
                        await _stream.ReadExactlyAsync(rawPacket, 8, packetDataLen);

                    // Then process the packet normally
                    var encryptedData = new ByteArray();
                    if (packetDataLen > 0)
                    {
                        var packetData = new byte[packetDataLen];
                        Buffer.BlockCopy(rawPacket, 8, packetData, 0, packetDataLen);
                        encryptedData.Write(packetData);
                    }

                    await ProcessPacketAsync(packetId, encryptedData, rawPacket);
                }
                catch (IOException ex)
                    when (ex.InnerException is SocketException socketEx
                        && (
                            socketEx.SocketErrorCode == SocketError.ConnectionReset
                            || socketEx.SocketErrorCode == SocketError.ConnectionAborted
                            || socketEx.SocketErrorCode == SocketError.OperationAborted
                        )
                    )
                {
                    // Connection was closed by the remote end
                    break;
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
        finally
        {
            await DisconnectAsync();
        }
    }

    /// <summary>
    ///     Processes received packet data
    /// </summary>
    private async Task ProcessPacketAsync(int packetId, ByteArray encryptedData, byte[] rawPacket)
    {
        var packetData = _protection.Decrypt(encryptedData.ToArray());
        var fittedPacket = PacketFitter(packetId, new ByteArray(packetData));

        // Store the complete raw packet data including headers
        fittedPacket.RawData = rawPacket;
        // Store the decrypted packet data (without headers)
        fittedPacket.DecryptedData = packetData;

        // Handle ActivateProtection packet
        if (ActivateProtection.IdStatic == packetId) // ActivateProtection packet ID
        {
            var keys = (List<object>?)fittedPacket.ObjectByAttributeName["keys"];
            if (keys is null)
            {
                throw new Exception("Failed to activate protection, because keys are null.");
            }
            var intKeys = keys.Select(k => (byte)k).ToArray();
            _protection.Activate(intKeys);
        }

        await OnPacketReceivedAsync(fittedPacket);
        await OnRawPacketReceivedAsync(rawPacket);
    }

    /// <summary>
    ///     Fits received data into appropriate packet type
    /// </summary>
    private AbstractPacket PacketFitter(int packetId, ByteArray packetData)
    {
        var packetType = PacketManager.GetPacketById(packetId);
        if (packetType == null)
        {
            var packet = new UnknownPacket();
            packet.Objects[0] = packetData;
            return packet;
        }

        var currentPacket = (AbstractPacket?)Activator.CreateInstance(packetType);
        if (currentPacket is null)
        {
            throw new Exception("currentPacket cannot be null");
        }
        try
        {
            currentPacket.Unwrap(new EByteArray(packetData.ToArray()));
        }
        catch (Exception ex)
        {
            // Notify about the failure
            _ = OnPacketUnwrapFailureAsync(packetType, packetId, ex);

            // Create an unknown packet instead
            var unknownPacket = new UnknownPacket();
            unknownPacket.Objects[0] = packetData;
            return unknownPacket;
        }

        return currentPacket;
    }
}

