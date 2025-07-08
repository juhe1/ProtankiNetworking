using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Thunder shooting at a target, with relative hit point.
    /// </summary>
    public class ThunderShootTargetIn : AbstractPacket
    {
        public static int Id { get; } = -190359403;
        public override string Description => "Thunder shoot at target with relative hit point";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // shooter
            StringCodec.Instance, // target
            Vector3DCodec.Instance, // relativeHitPoint
        };
        public override string[] Attributes => new string[]
        {
            "shooter",
            "target",
            "relativeHitPoint",
        };
    }
} 