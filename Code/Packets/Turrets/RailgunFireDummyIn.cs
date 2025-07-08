using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Railgun fire dummy in (shooter).
    /// </summary>
    public class RailgunFireDummyIn : AbstractPacket
    {
        public static int Id { get; } = 1459211021;
        public override string Description => "Railgun fire dummy in (shooter)";
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