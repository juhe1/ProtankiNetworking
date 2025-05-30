using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Status
{
    /// <summary>
    /// Updates a player's premium status
    /// </summary>
    public class PremiumStatusPacket : AbstractPacket
    {
        public static new int Id { get; } = -2069508071;
        public static new string Description { get; } = "Updates a player's premium status";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "timeLeft", "username" };
        public static new bool ShouldLog { get; } = false;
    }
} 