using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Chat
{
    /// <summary>
    /// Wipes all messages by a user in the lobby
    /// </summary>
    public class WipeLobbyMessages : AbstractPacket
    {
        public static new int Id { get; } = 1993050216;
        public static new string Description { get; } = "Wipes all messages by a user in the lobby";
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
