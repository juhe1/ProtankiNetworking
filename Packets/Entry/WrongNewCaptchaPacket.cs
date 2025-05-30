using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// The captcha was incorrect, a new one is sent
    /// </summary>
    public class WrongNewCaptchaPacket : AbstractPacket
    {
        public static new int Id { get; } = -373510957;
        public static new string Description { get; } = "The captcha was incorrect, a new one is sent";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(VectorByteCodec) };
        public static new string[] Attributes { get; } = new[] { "type", "imagedata" };
        public static new bool ShouldLog { get; } = false;
    }
} 