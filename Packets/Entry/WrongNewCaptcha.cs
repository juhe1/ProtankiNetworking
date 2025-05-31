using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// The captcha was incorrect, a new one is sent
    /// </summary>
    public class WrongNewCaptcha : AbstractPacket
    {
        public static new int Id { get; } = -373510957;
        public static new string Description { get; } = "The captcha was incorrect, a new one is sent";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            new VectorCodec(ByteCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "type",
            "imagedata",
        };
    }
}
