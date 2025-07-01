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
        public static int Id { get; } = 321971701;
        public override string Description => "Sets captcha hash keys";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(IntCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "keys",
        };
    }
}
