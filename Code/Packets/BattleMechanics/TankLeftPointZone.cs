

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a tank leaves a point zone (pointId, tankId).
/// </summary>
public class TankLeftPointZone : Packet
{
    [Encode(0)]
    public int PointId { get; set; }

    [Encode(1)]
    public string? TankId { get; set; }

    public const int ID_CONST = -1410197917;
    public override int Id => ID_CONST;
    public override string Description => "Tank left point zone (pointId, tankId)";


}