using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Railgun fire out (time, staticHitPoint, targets, targetHitPoints, targetIncarnations, targetPositions,
///     hitPointsWorld).
/// </summary>
public class RailgunFireOut : Packet
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
    public short[]? TargetIncarnations { get; set; }

    [Encode(5)]
    public Vector3D?[]? TargetPositions { get; set; }

    [Encode(6)]
    public Vector3D?[]? HitPointsWorld { get; set; }

    public const int ID_CONST = -484994657;

    public override string Description =>
        "Railgun fire out (time, staticHitPoint, targets, targetHitPoints, targetIncarnations, targetPositions, hitPointsWorld)";


}