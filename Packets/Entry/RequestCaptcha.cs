using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Request a captcha
    /// </summary>
    public class RequestCaptcha : AbstractPacket
    {
        public static new int Id { get; } = -349828108;
        public static new string Description { get; } = "Request a captcha";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "type",
        };
    }
}
