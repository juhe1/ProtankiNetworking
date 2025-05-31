using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Send a battle invite to a player
    /// </summary>
    public class SendInvite : AbstractPacket
    {
        public static new int Id { get; } = -864265623;
        public static new string Description { get; } = "Send a battle invite to a player";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "battleID",
        };
    }
}
