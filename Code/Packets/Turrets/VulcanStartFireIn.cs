namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan start fire event.
/// </summary>
public class VulcanStartFireIn : Packet
{
	[Encode(0)]
	public string? ShooterId { get; set; }

	public const int ID_CONST = -1616602030;
	public override int Id => ID_CONST;
	public override string Description => "Vulcan start fire event";
}
