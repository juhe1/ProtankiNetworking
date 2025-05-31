using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Smokey Shoot in
    /// </summary>
    public class SmokyShotIn : AbstractPacket
    {
        public static new int Id { get; } = -1334002026;
        public static new string Description { get; } = "Smokey Shoot in";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            Vector3DCodec.Instance,
            FloatCodec.Instance,
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "shooter",
            "target",
            "hitPoint",
            "weakeningCoeff",
            "isCritical",
        };
    }
}
