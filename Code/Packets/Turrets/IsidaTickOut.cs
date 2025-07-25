using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida tick out event.
/// </summary>
public class IsidaTickOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public short TargetIncarnation { get; set; }

    [Encode(2)]
    public Vector3D? TargetPosition { get; set; }

    [Encode(3)]
    public Vector3D? LocalHitPoint { get; set; }

    public const int ID_CONST = 244072998;
    public override int Id => ID_CONST;
    public override string Description => "Send Isida tick out event";


}