using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Chat
{
    /// <summary>
    /// Receives chat messages from the lobby
    /// </summary>
    public class ReceiveLobbyChat : AbstractPacket
    {
        public static new int Id { get; } = -1263520410;
        public static new string Description { get; } = "Receives chat messages from the lobby";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(ChatMessageCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "messages",
        };
    }
}
