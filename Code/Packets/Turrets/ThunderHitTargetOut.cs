using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder hit target out (time, relativeHitPoint, target, incarnation, targetPosition, hitPointWorld).
/// </summary>
public class ThunderHitTargetOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public Vector3D? RelativeHitPoint { get; set; }

    [Encode(2)]
    public string? Target { get; set; }

    [Encode(3)]
    public short Incarnation { get; set; }

    [Encode(4)]
    public Vector3D? TargetPosition { get; set; }

    [Encode(5)]
    public Vector3D? HitPointWorld { get; set; }

    public const int ID_CONST = 259979915;

    public override string Description =>
        "Thunder hit target out (time, relativeHitPoint, target, incarnation, targetPosition, hitPointWorld)";


}