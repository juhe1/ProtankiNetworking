using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending Smoky shoot target information.
    /// </summary>
    public class SmokyShootTargetIn : AbstractPacket
    {
        public static int Id { get; } = -1334002026;
        public override string Description => "Smokey Shoot in";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            Vector3DCodec.Instance,
            FloatCodec.Instance,
            BoolCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "shooter",
            "target",
            "hitPoint",
            "weakeningCoeff",
            "isCritical",
        };
    }
}
