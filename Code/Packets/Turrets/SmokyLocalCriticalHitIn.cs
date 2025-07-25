namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Smoky local critical hit in (target).
/// </summary>
public class SmokyLocalCriticalHitIn : Packet
{
	[Encode(0)]
	public string? Target { get; set; }

	public const int ID_CONST = -671618989;
	public override int Id => ID_CONST;
	public override string Description => "Smoky local critical hit in (target)";
}
