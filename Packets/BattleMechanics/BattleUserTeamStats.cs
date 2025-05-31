using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Battle user stats
    /// </summary>
    public class BattleUserTeamStats : AbstractPacket
    {
        public static new int Id { get; } = -497293992;
        public static new string Description { get; } = "Battle user stats";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            UserStatsCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "usersStat",
            "team",
        };
    }
}
