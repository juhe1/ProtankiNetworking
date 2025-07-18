using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for rankrange
/// </summary>
public class RankRangeCodec : CustomBaseCodec
{
    /// <summary>
    ///     Creates a new instance of RankRangeCodec
    /// </summary>
    private RankRangeCodec()
    {
    }

    /// <summary>
    ///     Gets the singleton instance of Rankrangecodec
    /// </summary>
    public static RankRangeCodec Instance { get; } = new();

    /// <summary>
    ///     Gets the list of attribute names for this codec
    /// </summary>
    protected override string[] Attributes => new[]
    {
        "maxRank",
        "minRank"
    };

    /// <summary>
    ///     Gets the list of codec objects for this codec
    /// </summary>
    protected override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance,
        IntCodec.Instance
    };
}