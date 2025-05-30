using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Updates the in-battle statistics of a player.
    /// </summary>
    public class UpdateBattlePlayerStatisticsPacket : AbstractPacket
    {
        public static new int Id { get; } = 696140460;
        public static new string Description { get; } = "Updates the in-battle statistics of a player.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(UserStatsCodec) };
        public static new string[] Attributes { get; } = new[] { "userStats" };
    }
} 