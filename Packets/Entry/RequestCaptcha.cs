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
        public static int Id { get; } = -349828108;
        public override string Description => "Request a captcha";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "type",
        };
    }
}
