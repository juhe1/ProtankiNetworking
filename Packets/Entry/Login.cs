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
        public static new int Id { get; } = -739684591;
        public static new string Description { get; } = "Login information sent by the client";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "password",
            "rememberMe",
        };
    }
}
