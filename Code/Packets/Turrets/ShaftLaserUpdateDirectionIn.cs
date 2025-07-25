

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for updating Shaft laser direction (shooterId, projectionOnVerticalAxis).
/// </summary>
public class ShaftLaserUpdateDirectionIn : Packet
{
    [Encode(0)]
    public string? ShooterId { get; set; }

    [Encode(1)]
    public float ProjectionOnVerticalAxis { get; set; }

    public const int ID_CONST = -534192254;
    public override int Id => ID_CONST;
    public override string Description => "Shaft laser update direction (shooterId, projectionOnVerticalAxis)";


}