using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for TargetHit structure used in hit packets.
    /// </summary>
    public class TargetHitCodec : CustomBaseCodec
    {
        public static TargetHitCodec Instance { get; } = new TargetHitCodec();

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
            StringCodec.Instance, // target (user id)
        };
    }
} 