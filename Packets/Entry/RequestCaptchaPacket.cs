using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Request a captcha
    /// </summary>
    public class RequestCaptchaPacket : AbstractPacket
    {
        public static new int Id { get; } = -349828108;
        public static new string Description { get; } = "Request a captcha";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "type" };
    }
} 