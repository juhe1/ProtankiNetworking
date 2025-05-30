using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Captcha is correct
    /// </summary>
    public class CaptchaCorrectPacket : AbstractPacket
    {
        public static new int Id { get; } = -819536476;
        public static new string Description { get; } = "Captcha is correct";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "type" };
    }
} 