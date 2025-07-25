using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Smoky shoot target information.
/// </summary>
public class SmokyShootTargetIn : AbstractPacket
{
    public const int ID_CONST = -1334002026;
    public override int Id => ID_CONST;
    public override string Description => "Smokey Shoot in";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance,
        Vector3DCodec.Instance,
        FloatCodec.Instance,
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "target",
        "hitPoint",
        "weakeningCoeff",
        "isCritical"
    };
}