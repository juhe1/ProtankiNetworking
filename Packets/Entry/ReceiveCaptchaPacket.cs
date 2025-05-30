using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Received a captcha image with its type
    /// </summary>
    public class ReceiveCaptchaPacket : AbstractPacket
    {
        public static new int Id { get; } = -1670408519;
        public static new string Description { get; } = "Received a captcha image with its type";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(VectorByteCodec) };
        public static new string[] Attributes { get; } = new[] { "type", "imagedata" };
        public static new bool ShouldLog { get; } = false;
    }
} 