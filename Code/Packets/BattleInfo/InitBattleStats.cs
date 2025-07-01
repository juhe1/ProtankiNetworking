using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Loads current battle statistics
    /// </summary>
    public class InitBattleStats : AbstractPacket
    {
        public static int Id { get; } = 522993449;
        public override string Description => "Loads current battle statistics";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
            BattleLimitsCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            VectorStringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
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
            "timeLeft",
        };
    }
}
