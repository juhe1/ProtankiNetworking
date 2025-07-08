using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Smoky local critical hit in (target).
    /// </summary>
    public class SmokyLocalCriticalHitIn : AbstractPacket
    {
        public static int Id { get; } = -671618989;
        public override string Description => "Smoky local critical hit in (target)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // target
        };
        public override string[] Attributes => new string[]
        {
            "target",
        };
    }
} 