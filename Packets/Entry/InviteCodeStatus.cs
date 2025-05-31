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
        public static new int Id { get; } = 444933603;
        public static new string Description { get; } = "Do we need an invite code to access the server?";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "inviteEnabled",
        };
    }
}
