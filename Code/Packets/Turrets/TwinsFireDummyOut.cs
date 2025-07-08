using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for fire dummy command out (time, barrel).
    /// </summary>
    public class TwinsFireDummyOut : AbstractPacket
    {
        public static int Id { get; } = -1805942142;
        public override string Description => "Fire dummy command out (time, barrel).";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            ByteCodec.Instance, // barrel
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "barrel",
        };
    }
} 