using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Chat
{
    /// <summary>
    /// Sends a chat message to the lobby
    /// </summary>
    public class SendLobbyChatPacket : AbstractPacket
    {
        public static new int Id { get; } = 705454610;
        public static new string Description { get; } = "Sends a chat message to the lobby";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "message" };
    }
} 