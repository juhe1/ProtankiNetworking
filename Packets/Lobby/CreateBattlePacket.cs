using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Creates a new battle
    /// </summary>
    public class CreateBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -2135234426;
        public static new string Description { get; } = "Creates a new battle";
        public static new Type[] CodecTypes { get; } = new[] {
            typeof(BoolCodec), typeof(IntCodec), typeof(IntCodec), typeof(BoolCodec), typeof(BattleLimitsCodec), typeof(StringCodec),
            typeof(IntCodec), typeof(StringCodec), typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec), typeof(RankRangeCodec),
            typeof(BoolCodec), typeof(IntCodec), typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec),
            typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec),
            typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec), typeof(BoolCodec)
        };
        public static new string[] Attributes { get; } = new[] {
            "autoBalance", "battleMode", "format", "friendlyFire", "battleLimits", "mapID",
            "maxPeopleCount", "name", "parkourMode", "privateBattle", "proBattle", "rankRange",
            "noRearm", "theme", "noSupplyBoxes", "noCrystalBoxes", "noSupplies", "noUpgrade",
            "lowResistance", "useDropTimings", "noGoldBoxes", "noGoldSiren", "noGoldDropZone",
            "noMedkit", "noMines", "randomGoldChance", "dependentCooldown"
        };
    }
} 