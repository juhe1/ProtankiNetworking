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
        public static int Id { get; } = -1263520410;
        public override string Description => "Receives chat messages from the lobby";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(ChatMessageCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "messages",
        };
    }
}
