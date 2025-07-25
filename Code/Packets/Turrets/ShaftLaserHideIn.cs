namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for hiding Shaft laser (shooterId only).
/// </summary>
public class ShaftLaserHideIn : Packet
{
	[Encode(0)]
	public string? ShooterId { get; set; }

	public const int ID_CONST = -380595194;
	public override int Id => ID_CONST;
	public override string Description => "Shaft laser hide (shooterId)";
}
