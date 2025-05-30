using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Answer the captcha
    /// </summary>
    public class AnswerCaptchaPacket : AbstractPacket
    {
        public static new int Id { get; } = 1271163230;
        public static new string Description { get; } = "Answer the captcha";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "type", "imagedata" };
    }
} 