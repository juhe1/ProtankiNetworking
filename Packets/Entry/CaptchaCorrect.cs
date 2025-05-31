using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Captcha is correct
    /// </summary>
    public class CaptchaCorrect : AbstractPacket
    {
        public static new int Id { get; } = -819536476;
        public static new string Description { get; } = "Captcha is correct";
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
