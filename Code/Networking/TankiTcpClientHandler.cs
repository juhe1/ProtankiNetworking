using System.Net.Sockets;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Security;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Networking;

/// <summary>
///     Handles a single TCP client connection for the TankiTcpListener
/// </summary>
public abstract class TankiTcpClientHandler
{
	protected readonly CancellationToken _cancellationToken;
	protected readonly TcpClient _client;
	protected readonly Protection _protection;
	private NetworkStream? _stream;

	protected TankiTcpClientHandler(
		TcpClient client,
		Protection protection,
		CancellationToken cancellationToken
	)
	{
		_client = client;
		_protection = protection;
		_cancellationToken = cancellationToken;
	}

	public Protection Protection => _protection;

	public async Task StartAsync()
	{
		try
		{
			_stream = _client.GetStream();
			await OnConnectedAsync();

			while (!_cancellationToken.IsCancellationRequested)
				try
				{
					var result = await PacketReader.ReadClientPacketAsync(_stream);
					if (result == null)
						// Connection closed by client
						break;

					await ProcessPacketAsync(result.Value.PacketId, result.Value.EncryptedData, result.Value.RawPacket);
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
					break;
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

	public async Task SendPacketAsync(Packet packet)
	{
		if (_stream == null || _client == null || !_client.Connected)
			return;

		try
		{
			byte[] packetData = PacketCoder.EncodeServerPacket(packet, _protection).ToTrimmedArray();
			await _stream.WriteAsync(packetData, 0, packetData.Length);
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

	private async Task ProcessPacketAsync(int packetId, ByteArray encryptedData, byte[] rawPacket)
	{
		var packetData = _protection.Decrypt(encryptedData.ToArray());
		var fittedPacket = PacketFitter(packetId, new ByteArray(packetData));
		// Store the complete raw packet data including headers
		fittedPacket.RawData = rawPacket;
		// Store the decrypted packet data (without headers)
		fittedPacket.DecryptedData = packetData;
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

	/// <summary>
	///     Called when the client connects
	/// </summary>
	protected abstract Task OnConnectedAsync();

	/// <summary>
	///     Called when a raw packet is received from the client
	/// </summary>
	/// <param name="rawPacket">The complete raw packet data including headers</param>
	protected abstract Task OnRawPacketReceivedAsync(byte[] rawPacket);

	/// <summary>
	///     Called when a packet is received from the client
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
	///     Called when the client disconnects
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
}
