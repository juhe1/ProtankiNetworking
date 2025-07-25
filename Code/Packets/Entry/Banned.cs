namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Account banned
/// </summary>
public class Banned : Packet
{
	[Encode(0)]
	public string? Reason { get; set; }

	public const int ID_CONST = -600078553;
	public override int Id => ID_CONST;
	public override string Description => "Account banned";
}
