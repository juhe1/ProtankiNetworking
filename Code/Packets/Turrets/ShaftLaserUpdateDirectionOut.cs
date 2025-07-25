

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft laser update direction out (projectionOnVerticalAxis).
/// </summary>
public class ShaftLaserUpdateDirectionOut : Packet
{
    [Encode(0)]
    public float ProjectionOnVerticalAxis { get; set; }

    public const int ID_CONST = 1224288585;
    public override int Id => ID_CONST;
    public override string Description => "Shaft laser update direction out (projectionOnVerticalAxis)";


}