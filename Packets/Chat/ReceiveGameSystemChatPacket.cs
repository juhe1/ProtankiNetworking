using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Chat
{
    /// <summary>
    /// Received a system message in the game chat
    /// </summary>
    public class ReceiveGameSystemChatPacket : AbstractPacket
    {
        public static new int Id { get; } = 606668848;
        public static new string Description { get; } = "Received a system message in the game chat";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "message" };
    }
} 