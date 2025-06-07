using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Received a captcha image with its type
    /// </summary>
    public class ReceiveCaptcha : AbstractPacket
    {
        public static int Id { get; } = -1670408519;
        public override string Description => "Received a captcha image with its type";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            new VectorCodec(ByteCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "type",
            "imagedata",
        };
    }
}
