using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder shooting at a target, with relative hit point.
/// </summary>
public class ThunderShootTargetIn : AbstractPacket
{
    public static int IdStatic { get; } = -190359403;
    public override int Id => IdStatic;
    public override string Description => "Thunder shoot at target with relative hit point";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // shooter
        StringCodec.Instance, // target
        Vector3DCodec.Instance // relativeHitPoint
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "target",
        "relativeHitPoint"
    };
}