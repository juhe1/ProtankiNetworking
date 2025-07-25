namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder shoot in (shooter only).
/// </summary>
public class ThunderShootIn : Packet
{
	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 958509220;
	public override int Id => ID_CONST;
	public override string Description => "Thunder shoot in (shooter)";
}
