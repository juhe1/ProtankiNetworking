using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Freeze turret starting fire (shooter only).
    /// </summary>
    public class FreezeStartFireIn : AbstractPacket
    {
        public static int Id { get; } = -1171353580;
        public override string Description => "Freeze start fire (shooter)";
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