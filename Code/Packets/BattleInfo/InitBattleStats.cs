using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Loads current battle statistics
/// </summary>
public class InitBattleStats : AbstractPacket
{
    public const int ID_CONST = 522993449;
    public override int Id => ID_CONST;
    public override string Description => "Loads current battle statistics";

    public override BaseCodec[] CodecObjects =>
        new BaseCodec[]
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
            new VectorCodec(StringCodec.Instance, true),
            IntCodec.Instance,
        };

    public override string[] Attributes =>
        new[]
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

