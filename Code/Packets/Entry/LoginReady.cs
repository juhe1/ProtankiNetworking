using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Server sends options for Login
/// </summary>
public class LoginReady : Packet
{
	[Encode(0)]
	public Resource? BgResourceID { get; set; }

	[Encode(1)]
	public bool RequireEmail { get; set; }

	[Encode(2)]
	public int MaxPWLen { get; set; }

	[Encode(3)]
	public int MinPWLen { get; set; }

	public const int ID_CONST = -1277343167;
	public override int Id => ID_CONST;
	public override string Description => "Server sends options for Login";
}
