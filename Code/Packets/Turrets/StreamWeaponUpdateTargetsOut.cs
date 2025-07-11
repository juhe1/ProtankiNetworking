using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for stream weapon update targets (time, direction, targets).
/// </summary>
public class StreamWeaponUpdateTargetsOut : AbstractPacket
{
    public const int ID_CONST = -1889502569;
    public override int Id => ID_CONST;
    public override string Description => "Stream weapon update targets (time, direction, targets)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        Vector3DCodec.Instance, // direction
        new VectorCodec(TargetPositionCodec.Instance, false) // targets
    };

    public override string[] Attributes => new[]
    {
        "time",
        "direction",
        "targets"
    };
}