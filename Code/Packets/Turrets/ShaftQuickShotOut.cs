using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft quick shot out (time, staticHitPoint, targets, targetHitPoints, targetIncarnation, targetPosition,
///     hitPointWorld).
/// </summary>
public class ShaftQuickShotOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public Vector3D? StaticHitPoint { get; set; }

    [Encode(2)]
    public string?[]? Targets { get; set; }

    [Encode(3)]
    public Vector3D?[]? TargetHitPoints { get; set; }

    [Encode(4)]
    public short[]? TargetIncarnation { get; set; }

    [Encode(5)]
    public Vector3D?[]? TargetPosition { get; set; }

    [Encode(6)]
    public Vector3D?[]? HitPointWorld { get; set; }

    public const int ID_CONST = -2030760866;
    public override int Id => ID_CONST;
    public override string Description =>
        "Shaft quick shot out (time, staticHitPoint, targets, targetHitPoints, targetIncarnation, targetPosition, hitPointWorld)";


}