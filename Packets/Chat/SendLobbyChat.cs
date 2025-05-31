using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Chat
{
    /// <summary>
    /// Sends a chat message to the lobby
    /// </summary>
    public class SendLobbyChat : AbstractPacket
    {
        public static new int Id { get; } = 705454610;
        public static new string Description { get; } = "Sends a chat message to the lobby";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "message",
        };
    }
}
