using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Do we need an invite code to access the server?
    /// </summary>
    public class InviteCodeStatus : AbstractPacket
    {
        public static int Id { get; } = 444933603;
        public override string Description => "Do we need an invite code to access the server?";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BoolCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "inviteEnabled",
        };
    }
}
