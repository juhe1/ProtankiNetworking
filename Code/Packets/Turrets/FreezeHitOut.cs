using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Freeze hit out (time, targets, incarnations, positions, hitPoints).
/// </summary>
public class FreezeHitOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public string?[]? Targets { get; set; }

    [Encode(2)]
    public short[]? Incarnations { get; set; }

    [Encode(3)]
    public Vector3D?[]? Positions { get; set; }

    [Encode(4)]
    public Vector3D?[]? HitPoints { get; set; }

    public const int ID_CONST = 1395251766;
    public override int Id => ID_CONST;
    public override string Description => "Freeze hit out (time, targets, incarnations, positions, hitPoints)";


}