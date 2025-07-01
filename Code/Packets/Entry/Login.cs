using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Login information sent by the client
    /// </summary>
    public class Login : AbstractPacket
    {
        public static int Id { get; } = -739684591;
        public override string Description => "Login information sent by the client";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "password",
            "rememberMe",
        };
    }
}
