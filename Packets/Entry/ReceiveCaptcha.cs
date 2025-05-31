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
        public static new int Id { get; } = -1670408519;
        public static new string Description { get; } = "Received a captcha image with its type";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            new VectorCodec(ByteCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "type",
            "imagedata",
        };
    }
}
