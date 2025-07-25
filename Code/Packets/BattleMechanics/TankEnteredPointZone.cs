namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a tank enters a point zone (pointId, tankId).
/// </summary>
public class TankEnteredPointZone : Packet
{
	[Encode(0)]
	public int PointId { get; set; }

	[Encode(1)]
	public string? TankId { get; set; }

	public const int ID_CONST = -456245145;
	public override int Id => ID_CONST;
	public override string Description => "Tank entered point zone (pointId, tankId)";
}
