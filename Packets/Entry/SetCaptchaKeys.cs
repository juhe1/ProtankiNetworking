using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Sets captcha hash keys
    /// </summary>
    public class SetCaptchaKeys : AbstractPacket
    {
        public static new int Id { get; } = 321971701;
        public static new string Description { get; } = "Sets captcha hash keys";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(IntCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "keys",
        };
    }
}
