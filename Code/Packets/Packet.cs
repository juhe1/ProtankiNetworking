namespace ProtankiNetworking.Packets;

/// <summary>
///     Class for packets. This class is used to define the structure of
///     packets that are sent and received by the server.
/// </summary>
public abstract class Packet
{
	/// <summary>
	///     Length of the packet header in bytes
	/// </summary>
	public const int HEADER_LEN = 8;

	/// <summary>
	///     Packet identifier
	/// </summary>
	public virtual int Id { get; set; } = 0;

	/// <summary>
	///     Description of the packet
	/// </summary>
	public virtual string Description => "Unknown packet";

	/// <summary>
	///     The original raw packet data
	/// </summary>
	public byte[] RawData { get; set; } = Array.Empty<byte>();

	/// <summary>
	///     The decrypted packet data (without headers)
	/// </summary>
	public byte[] DecryptedData { get; set; } = Array.Empty<byte>();
}
