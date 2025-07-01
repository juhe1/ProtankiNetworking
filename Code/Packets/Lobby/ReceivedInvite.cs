using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Accepts a player's battle invite
    /// </summary>
    public class ReceivedInvite : AbstractPacket
    {
        public static int Id { get; } = 810713262;
        public override string Description => "Accepts a player's battle invite";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
        };
    }
}
