using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Battle user stats
    /// </summary>
    public class BattleUserTeamStatsPacket : AbstractPacket
    {
        public static new int Id { get; } = -497293992;
        public static new string Description { get; } = "Battle user stats";
        public static new Type[] CodecTypes { get; } = new[] { typeof(UserStatsCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "usersStat", "team" };
    }
} 