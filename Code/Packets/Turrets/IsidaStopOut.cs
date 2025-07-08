using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending Isida stop out event.
    /// </summary>
    public class IsidaStopOut : AbstractPacket
    {
        public static int Id { get; } = -1051248475;
        public override string Description => "Send Isida stop out event";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
        };
        public override string[] Attributes => new string[]
        {
            "time",
        };
    }
} 