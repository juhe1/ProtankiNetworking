using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Creates a new battle
    /// </summary>
    public class CreateBattle : AbstractPacket
    {
        public static new int Id { get; } = -2135234426;
        public static new string Description { get; } = "Creates a new battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            BoolCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            BattleLimitsCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            RankRangeCodec.Instance,
            BoolCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "autoBalance",
            "battleMode",
            "format",
            "friendlyFire",
            "battleLimits",
            "mapID",
            "maxPeopleCount",
            "name",
            "parkourMode",
            "privateBattle",
            "proBattle",
            "rankRange",
            "noRearm",
            "theme",
            "noSupplyBoxes",
            "noCrystalBoxes",
            "noSupplies",
            "noUpgrade",
            "lowResistance",
            "useDropTimings",
            "noGoldBoxes",
            "noGoldSiren",
            "noGoldDropZone",
            "noMedkit",
            "noMines",
            "randomGoldChance",
            "dependentCooldown",
        };
    }
}
