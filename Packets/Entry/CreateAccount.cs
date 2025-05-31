using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Create new account
    /// </summary>
    public class CreateAccount : AbstractPacket
    {
        public static new int Id { get; } = 427083290;
        public static new string Description { get; } = "Create new account";
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
