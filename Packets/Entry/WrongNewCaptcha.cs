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
        public static int Id { get; } = -373510957;
        public override string Description => "The captcha was incorrect, a new one is sent";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            new VectorCodec(ByteCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "type",
            "imagedata",
        };
    }
}
