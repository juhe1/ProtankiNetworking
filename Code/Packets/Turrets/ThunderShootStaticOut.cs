using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder shoot static (time, hitPoint).
/// </summary>
public class ThunderShootStaticOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public Vector3D? HitPoint { get; set; }

    public const int ID_CONST = 1501310158;
    public override int Id => ID_CONST;
    public override string Description => "Thunder shoot static (time, hitPoint)";


}