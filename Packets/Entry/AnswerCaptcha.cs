using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Answer the captcha
    /// </summary>
    public class AnswerCaptcha : AbstractPacket
    {
        public static new int Id { get; } = 1271163230;
        public static new string Description { get; } = "Answer the captcha";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "type",
            "imagedata",
        };
    }
}
