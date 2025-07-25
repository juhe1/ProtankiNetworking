using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida set target out event.
/// </summary>
public class IsidaSetTargetOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public string? Target { get; set; }

    [Encode(2)]
    public short TargetIncarnation { get; set; }

    [Encode(3)]
    public Vector3D? HitPoint { get; set; }

    public const int ID_CONST = 381067984;
    public override int Id => ID_CONST;
    public override string Description => "Send Isida set target out event";


}