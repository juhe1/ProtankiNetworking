namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Smoky shoot air event.
/// </summary>
public class SmokyShootAirIn : Packet
{
	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1032328347;
	public override int Id => ID_CONST;
	public override string Description => "Send Smoky shoot air event";
}
