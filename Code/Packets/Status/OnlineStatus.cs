namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Updates Player's Online Status
/// </summary>
public class OnlineStatus : Packet
{
	[Encode(0)]
	public bool Online { get; set; }

	[Encode(1)]
	public int ServerID { get; set; }

	[Encode(2)]
	public string? Username { get; set; }

	public const int ID_CONST = 2041598093;
	public override int Id => ID_CONST;
	public override string Description => "Updates Player's Online Status";
}
