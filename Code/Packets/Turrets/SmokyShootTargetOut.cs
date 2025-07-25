using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Our smoky shot hit a target
/// </summary>
public class SmokyShootTargetOut : AbstractPacket
{
    public const int ID_CONST = 229267683;
    public override int Id => ID_CONST;
    public override string Description => "Our smoky shot hit a target";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        StringCodec.Instance,
        ShortCodec.Instance,
        Vector3DCodec.Instance,
        Vector3DCodec.Instance,
        Vector3DCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "target",
        "incarnationID",
        "targetBodyPosition",
        "localHitPoint",
        "globalHitPoint"
    };
}