using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Chat
{
    /// <summary>
    /// Sends a message to the game chat
    /// </summary>
    public class SendGameChatPacket : AbstractPacket
    {
        public static new int Id { get; } = 945463181;
        public static new string Description { get; } = "Sends a message to the game chat";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "message", "teamOnly" };
    }
} 