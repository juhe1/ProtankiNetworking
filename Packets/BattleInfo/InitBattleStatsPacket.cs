using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Loads current battle statistics
    /// </summary>
    public class InitBattleStatsPacket : AbstractPacket
    {
        public static new int Id { get; } = 522993449;
        public static new string Description { get; } = "Loads current battle statistics";
        public static new Type[] CodecTypes { get; } = new[]
        {
            typeof(IntCodec),
            typeof(IntCodec),
            typeof(IntCodec),
            typeof(BattleLimitsCodec),
            typeof(StringCodec),
            typeof(IntCodec),
            typeof(BoolCodec),
            typeof(IntCodec),
            typeof(BoolCodec),
            typeof(VectorStringCodec),
            typeof(IntCodec)
        };
        public static new string[] Attributes { get; } = new[]
        {
            "battleMode",
            "format",
            "fund",
            "battleLimits",
            "mapName",
            "maxPeopleCount",
            "parkourMode",
            "premiumBonusPercentage",
            "spectator",
            "suspiciousUsers",
            "timeLeft"
        };
    }
} 