using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Sets captcha hash keys
    /// </summary>
    public class SetCaptchaKeysPacket : AbstractPacket
    {
        public static new int Id { get; } = 321971701;
        public static new string Description { get; } = "Sets captcha hash keys";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorIntCodec) };
        public static new string[] Attributes { get; } = new[] { "keys" };
    }
} 