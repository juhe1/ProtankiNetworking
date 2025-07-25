using ProtankiNetworking.EncodableData;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for stream weapon update targets (time, direction, targets).
/// </summary>
public class StreamWeaponUpdateTargetsOut : Packet
{
    [Encode(0)]
    public int Time { get; set; }

    [Encode(1)]
    public Vector3D? Direction { get; set; }

    [Encode(2)]
    public TargetPosition?[]? Targets { get; set; }

    public const int ID_CONST = -1889502569;
    public override int Id => ID_CONST;
    public override string Description => "Stream weapon update targets (time, direction, targets)";


}