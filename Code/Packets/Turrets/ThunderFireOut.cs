using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Thunder fire (time).
    /// </summary>
    public class ThunderFireOut : AbstractPacket
    {
        public static int Id { get; } = -136344740;
        public override string Description => "Thunder fire (time)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time (was var_2174)
        };
        public override string[] Attributes => new string[]
        {
            "time",
        };
    }
} 