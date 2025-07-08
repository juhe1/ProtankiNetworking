using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending Twins fire dummy event.
    /// </summary>
    public class TwinsFireDummyIn : AbstractPacket
    {
        public static int Id { get; } = -328554480;
        public override string Description => "Send Twins fire dummy event";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // shooter
            ByteCodec.Instance, // fireType
        };
        public override string[] Attributes => new string[]
        {
            "shooter",
            "fireType",
        };
    }
} 