using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida set target out event.
/// </summary>
public class IsidaSetTargetOut : AbstractPacket
{
    public static int IdStatic { get; } = 381067984;
    public override int Id => IdStatic;
    public override string Description => "Send Isida set target out event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        StringCodec.Instance, // target
        ShortCodec.Instance, // targetIncarnation
        Vector3DCodec.Instance // hitPoint
    };

    public override string[] Attributes => new[]
    {
        "time",
        "target",
        "targetIncarnation",
        "hitPoint"
    };
}