using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending Isida reset target out event.
    /// </summary>
    public class IsidaResetTargetOut : AbstractPacket
    {
        public static int Id { get; } = -248693565;
        public override string Description => "Send Isida reset target out event";
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