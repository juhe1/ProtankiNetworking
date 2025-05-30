using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Status
{
    /// <summary>
    /// Subscribe to status updates of a player.
    /// </summary>
    public class SubscribeStatusPacket : AbstractPacket
    {
        public static new int Id { get; } = 1774907609;
        public static new string Description { get; } = "Subscribe to status updates of a player.";
        public static new string[] Attributes { get; } = new[] { "username" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new bool ShouldLog { get; } = false;
    }
} 