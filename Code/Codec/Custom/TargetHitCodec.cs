using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for TargetHit structure used in hit packets.
/// </summary>
public class TargetHitCodec : CustomBaseCodec
{
    public static TargetHitCodec Instance { get; } = new();

    protected override string[] Attributes => new[]
    {
        "direction",
        "localHitPoint",
        "numberHits",
        "target"
    };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        Vector3DCodec.Instance, // direction
        Vector3DCodec.Instance, // localHitPoint
        ByteCodec.Instance, // numberHits
        StringCodec.Instance // target (user id)
    };
}