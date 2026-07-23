using System.Net;
using System.Net.Sockets;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Packets.Init;
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
	private readonly Socks5ProxyInfo? _socks5Proxy;
	private CancellationTokenSource _cancellationTokenSource;
	private TcpClient? _client;
	private Task? _processingTask;
	private NetworkStream? _stream;
	private bool _isDisconnected = false;
	private readonly object _disconnectLock = new();

	/// <summary>
	///     Creates a new instance of TankiTcpClient
	/// </summary>
	/// <param name="serverEndPoint">The server endpoint to connect to</param>
	/// <param name="protection">The protection instance for packet encryption/decryption</param>
	/// <param name="socks5Proxy">Optional SOCKS5 proxy configuration. If set, all traffic is routed through the proxy.</param>
	protected TankiTcpClient(IPEndPoint serverEndPoint, Protection protection, Socks5ProxyInfo? socks5Proxy = null)
	{
		_serverEndPoint = serverEndPoint;
		_protection = protection;
		_socks5Proxy = socks5Proxy;
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
	protected abstract Task OnPacketReceivedAsync(Packet packet);

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
	public async Task SendPacketAsync(Packet packet)
	{
		if (_stream == null || _client == null || !_client.Connected)
			return;

		try
		{
			byte[] packetData = PacketCoder.EncodePacket(packet, _protection).ToTrimmedArray();
			await _stream.WriteAsync(packetData, 0, packetData.Length);
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
			if (_socks5Proxy != null)
			{
				// Route connection through SOCKS5 proxy
				_client = await Socks5ProxyClient.ConnectThroughProxyAsync(
					_socks5Proxy,
					_serverEndPoint
				);
			}
			else
			{
				// Direct connection
				_client = new TcpClient();
				await _client.ConnectAsync(_serverEndPoint.Address, _serverEndPoint.Port);
			}
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
	/// When called, will disconnect from the server.
	/// When server closes the connection this is called.
	/// </summary>
	public async Task DisconnectAsync()
	{
		lock (_disconnectLock)
		{
			if (_isDisconnected)
				return;
			_isDisconnected = true;
		}

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
					if (_stream is null)
					{
						throw new Exception("_stream cannot be null");
					}

					var result = await PacketReader.ReadPacketAsync(_stream, _protection);
					await ProcessPacketAsync(result.PacketId, result.DecryptedData, result.RawPacket);
				}
				catch (IOException ex)
					when (ex.InnerException is SocketException socketEx
						&& (
							socketEx.SocketErrorCode == SocketError.ConnectionReset
							|| socketEx.SocketErrorCode == SocketError.ConnectionAborted
							|| socketEx.SocketErrorCode == SocketError.OperationAborted
							|| socketEx.SocketErrorCode == SocketError.Shutdown
							|| socketEx.SocketErrorCode == SocketError.NetworkReset
							|| socketEx.SocketErrorCode == SocketError.NotConnected
						)
					)
				{
					// Connection was closed by the remote end
					_ = DisconnectAsync();
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
			_ = DisconnectAsync();
		}
	}

	/// <summary>
	///     Processes received packet data
	/// </summary>
	private async Task ProcessPacketAsync(int packetId, byte[] packetData, byte[] rawPacket)
	{
		var fittedPacket = PacketFitter(packetId, new ByteArray(packetData));

		// Store the complete raw packet data including headers
		fittedPacket.RawData = rawPacket;
		// Store the decrypted packet data (without headers)
		fittedPacket.DecryptedData = packetData;

		// Handle ActivateProtection packet
		if (ActivateProtectionInPacket.ID_CONST == packetId) // ActivateProtection packet ID
		{
			byte[] keys = ((ActivateProtectionInPacket)fittedPacket).Keys!;
			_protection.Activate(keys);
		}

		await OnPacketReceivedAsync(fittedPacket);
		await OnRawPacketReceivedAsync(rawPacket);
	}

	/// <summary>
	///     Fits received data into appropriate packet type
	/// </summary>
	private Packet PacketFitter(int packetId, ByteArray packetData)
	{
		var packet = PacketManager.CreatePacketById(packetId);
		if (packet == null)
		{
			packet = new UnknownPacket();
			packet.Id = packetId;
			return packet;
		}

		try
		{
			PacketCoder.DecodePacket(new EByteArray(packetData.ToArray()), packet);
		}
		catch (Exception ex)
		{
			// Notify about the failure
			_ = OnPacketUnwrapFailureAsync(packet.GetType(), packetId, ex);

			// Create an unknown packet instead
			var unknownPacket = new UnknownPacket();
			unknownPacket.Id = packetId;
			return unknownPacket;
		}

		return packet;
	}
}
