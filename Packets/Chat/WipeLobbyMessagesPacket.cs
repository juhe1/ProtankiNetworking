using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Chat
{
    /// <summary>
    /// Wipes all messages by a user in the lobby
    /// </summary>
    public class WipeLobbyMessagesPacket : AbstractPacket
    {
        public static new int Id { get; } = 1993050216;
        public static new string Description { get; } = "Wipes all messages by a user in the lobby";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 