using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Accepts a player's battle invite
    /// </summary>
    public class AcceptInvite : AbstractPacket
    {
        public static new int Id { get; } = 814687528;
        public static new string Description { get; } = "Accepts a player's battle invite";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
        };
    }
}
