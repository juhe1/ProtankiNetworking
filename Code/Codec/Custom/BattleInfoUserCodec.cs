using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for battleinfouser
/// </summary>
public class BattleInfoUserCodec : CustomBaseCodec
{
    /// <summary>
    ///     Creates a new instance of BattleInfoUserCodec
    /// </summary>
    private BattleInfoUserCodec()
    {
    }

    /// <summary>
    ///     Gets the singleton instance of BattleInfoUserCodec
    /// </summary>
    public static BattleInfoUserCodec Instance { get; } = new();

    /// <summary>
    ///     Gets the list of attribute names for this codec
    /// </summary>
    protected override string[] Attributes => new[]
    {
        "kills",
        "score",
        "suspicious",
        "user"
    };

    /// <summary>
    ///     Gets the list of codec objects for this codec
    /// </summary>
    protected override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance,
        IntCodec.Instance,
        BoolCodec.Instance,
        StringCodec.Instance
    };
}