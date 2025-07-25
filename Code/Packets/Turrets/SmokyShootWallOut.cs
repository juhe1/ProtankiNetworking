using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Smokey Shoot out
/// </summary>
public class SmokyShootWallOut : Packet
{
    [Encode(0)]
    public int ClientTime { get; set; }

    [Encode(1)]
    public Vector3D? HitPoint { get; set; }

    public const int ID_CONST = 1470597926;
    public override int Id => ID_CONST;
    public override string Description => "Smokey Shoot out";


}