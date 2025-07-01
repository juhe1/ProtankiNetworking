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
        public static int Id { get; } = 705454610;
        public override string Description => "Sends a chat message to the lobby";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "message",
        };
    }
}
