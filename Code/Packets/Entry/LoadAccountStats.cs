using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Loads the player's own account stats
/// </summary>
public class LoadAccountStats : AbstractPacket
{
    public const int IdStatic = 907073245;
    public override int Id => IdStatic;
    public override string Description => "Loads the player's own account stats";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance,
        BoolCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance,
        ByteCodec.Instance,
        FloatCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance,
        StringCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "crystals",
        "currentRankXP",
        "doubleCrystalLength",
        "hasDoubleCrystal",
        "nextRankXP",
        "ratingRank",
        "rank",
        "rating",
        "XP",
        "serverNumber",
        "username",
        "userProfileUrl"
    };
}