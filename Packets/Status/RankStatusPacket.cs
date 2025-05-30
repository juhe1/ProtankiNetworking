using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Status
{
    /// <summary>
    /// Loads the rank of a player
    /// </summary>
    public class RankStatusPacket : AbstractPacket
    {
        public static new int Id { get; } = -962759489;
        public static new string Description { get; } = "Loads the rank of a player";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "rank", "username" };
        public static new bool ShouldLog { get; } = false;
    }
} 