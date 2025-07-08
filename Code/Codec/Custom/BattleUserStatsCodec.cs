using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for battleuserstats
/// </summary>
public class BattleUserStatsCodec : CustomBaseCodec
{
    /// <summary>
    ///     Creates a new instance of BattleUserStatsCodec
    /// </summary>
    private BattleUserStatsCodec()
    {
    }

    /// <summary>
    ///     Gets the singleton instance of BattleUserStatsCodec
    /// </summary>
    public static BattleUserStatsCodec Instance { get; } = new();

    /// <summary>
    ///     Gets the list of attribute names for this codec
    /// </summary>
    protected override string[] Attributes => new[]
    {
        "deaths",
        "kills",
        "score",
        "user"
    };

    /// <summary>
    ///     Gets the list of codec objects for this codec
    /// </summary>
    protected override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance,
        StringCodec.Instance
    };
}