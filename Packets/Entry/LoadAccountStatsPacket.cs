using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Loads the player's own account stats
    /// </summary>
    public class LoadAccountStatsPacket : AbstractPacket
    {
        public static new int Id { get; } = 907073245;
        public static new string Description { get; } = "Loads the player's own account stats";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(IntCodec), typeof(IntCodec), typeof(BoolCodec), typeof(IntCodec), typeof(IntCodec), typeof(ByteCodec), typeof(FloatCodec), typeof(IntCodec), typeof(IntCodec), typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "crystals", "currentRankXP", "doubleCrystalLength", "hasDoubleCrystal", "nextRankXP", "ratingRank", "rank", "rating", "XP", "serverNumber", "username", "userProfileUrl" };
    }
} 