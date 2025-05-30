using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Chat
{
    /// <summary>
    /// Receives chat messages from the lobby
    /// </summary>
    public class ReceiveLobbyChatPacket : AbstractPacket
    {
        public static new int Id { get; } = -1263520410;
        public static new string Description { get; } = "Receives chat messages from the lobby";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorChatMessageCodec) };
        public static new string[] Attributes { get; } = new[] { "messages" };
    }
} 