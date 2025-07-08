using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Flamethrower starting fire (shooter only).
    /// </summary>
    public class FlamethrowerStartFireIn : AbstractPacket
    {
        public static int Id { get; } = 1212381771;
        public override string Description => "Flamethrower start fire (shooter)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // shooter
        };
        public override string[] Attributes => new string[]
        {
            "shooter",
        };
    }
} 