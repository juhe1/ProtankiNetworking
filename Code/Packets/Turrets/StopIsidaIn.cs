using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for stopping Isida action.
    /// </summary>
    public class StopIsidaIn : AbstractPacket
    {
        public static int Id { get; } = 981035905;
        public override string Description => "Stop Isida action event";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // userId
        };
        public override string[] Attributes => new string[]
        {
            "userId",
        };
    }
} 