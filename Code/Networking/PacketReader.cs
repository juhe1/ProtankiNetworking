using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Security;

namespace ProtankiNetworking.Networking;

/// <summary>
///     Result of reading and processing a packet from a stream.
///     Contains the raw packet, parsed header info, and decrypted/decompressed payload.
/// </summary>
public readonly struct PacketReadResult
{
	/// <summary>
	///     The complete raw packet data including header bytes (big-endian, as received from the network).
	/// </summary>
	public byte[] RawPacket { get; }

	/// <summary>
	///     The parsed packet identifier.
	/// </summary>
	public int PacketId { get; }

	/// <summary>
	///     Whether the packet payload was flagged as compressed.
	/// </summary>
	public bool IsCompressed { get; }

	/// <summary>
	///     The decrypted (and decompressed, if applicable) packet payload, without headers.
	/// </summary>
	public byte[] DecryptedData { get; }

	public PacketReadResult(byte[] rawPacket, int packetId, bool isCompressed, byte[] decryptedData)
	{
		RawPacket = rawPacket;
		PacketId = packetId;
		IsCompressed = isCompressed;
		DecryptedData = decryptedData;
	}
}

/// <summary>
///     Static helper for reading packets from any stream.
///     Handles header decoding, payload decryption, and optional decompression.
/// </summary>
public static class PacketReader
{
	/// <summary>
	///     Maximum allowed packet size (1 MB). Packets larger than this are considered invalid.
	/// </summary>
	private const int MaxPacketSize = 1024 * 1024;

	/// <summary>
	///     Reads a complete packet from the stream: header (8 bytes) + payload.
	///     Decrypts the payload and decompresses it if the compressed flag is set.
	/// </summary>
	/// <param name="stream">The stream to read from (e.g. NetworkStream, FileStream, MemoryStream).</param>
	/// <param name="protection">The protection instance for decryption.</param>
	/// <returns>A <see cref="PacketReadResult"/> containing the raw packet, parsed ID, and processed payload.</returns>
	public static async Task<PacketReadResult> ReadPacketAsync(Stream stream, Protection protection)
	{
		// Read header bytes
		var packetLenBytes = new byte[4];
		var packetIdBytes = new byte[4];

		await stream.ReadExactlyAsync(packetLenBytes, 0, 4);
		await stream.ReadExactlyAsync(packetIdBytes, 0, 4);

		// Create complete raw packet buffer first with original byte order
		var rawPacket = new byte[8];
		Buffer.BlockCopy(packetLenBytes, 0, rawPacket, 0, 4);
		Buffer.BlockCopy(packetIdBytes, 0, rawPacket, 4, 4);

		// Convert from big-endian to little-endian for BitConverter
		Array.Reverse(packetLenBytes);
		Array.Reverse(packetIdBytes);

		int header = BitConverter.ToInt32(packetLenBytes, 0);
		bool isCompressed = ((header >> 24) & 0x40) != 0;
		int packetLen = header & 0xFFFFFF; // length (24 bits)
		int packetId = BitConverter.ToInt32(packetIdBytes, 0);
		int packetDataLen = packetLen - Packet.HEADER_LEN;

		// Validate packet length
		if (packetLen < Packet.HEADER_LEN || packetLen > MaxPacketSize)
			throw new InvalidOperationException(
				$"Invalid packet length: {packetLen} packetId: {packetId}"
			);

		// Resize raw packet to full length if needed
		if (packetLen > 8)
			Array.Resize(ref rawPacket, packetLen);

		// Read packet data if any
		if (packetDataLen > 0)
			await stream.ReadExactlyAsync(rawPacket, 8, packetDataLen);

		// Decrypt and decompress payload
		byte[] data = Array.Empty<byte>();
		if (packetDataLen > 0)
		{
			data = new byte[packetDataLen];
			Buffer.BlockCopy(rawPacket, 8, data, 0, packetDataLen);

			data = protection.Decrypt(data);

			// Decompress if flagged
			if (isCompressed)
			{
				using var ms = new MemoryStream(data);
				using var ds = new InflaterInputStream(
					ms,
					new ICSharpCode.SharpZipLib.Zip.Compression.Inflater(noHeader: true)
				);
				using var outMs = new MemoryStream();
				ds.CopyTo(outMs);
				data = outMs.ToArray();
			}
		}

		return new PacketReadResult(rawPacket, packetId, isCompressed, data);
	}
}
