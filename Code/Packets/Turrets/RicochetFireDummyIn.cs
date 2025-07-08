using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Ricochet fire dummy event (shooter only).
    /// </summary>
    public class RicochetFireDummyIn : AbstractPacket
    {
        public static int Id { get; } = -1670466290;
        public override string Description => "Ricochet fire dummy event (shooter)";
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