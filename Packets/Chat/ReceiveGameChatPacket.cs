using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Chat
{
    /// <summary>
    /// Receives a message from the game chat
    /// </summary>
    public class ReceiveGameChatPacket : AbstractPacket
    {
        public static new int Id { get; } = 1259981343;
        public static new string Description { get; } = "Receives a message from the game chat";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "message", "team" };
    }
} 