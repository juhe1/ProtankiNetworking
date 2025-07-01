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
        public static int Id { get; } = 427083290;
        public override string Description => "Create new account";
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
