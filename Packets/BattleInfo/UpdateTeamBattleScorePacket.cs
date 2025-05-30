using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Update the score of a team within battle
    /// </summary>
    public class UpdateTeamBattleScorePacket : AbstractPacket
    {
        public static new int Id { get; } = 561771020;
        public static new string Description { get; } = "Update the score of a team within battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "team", "score" };
    }
} 