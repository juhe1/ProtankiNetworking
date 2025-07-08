using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Flamethrower stopping fire (shooter only).
    /// </summary>
    public class FlamethrowerStopFireIn : AbstractPacket
    {
        public static int Id { get; } = 1333088437;
        public override string Description => "Flamethrower stop fire (shooter)";
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