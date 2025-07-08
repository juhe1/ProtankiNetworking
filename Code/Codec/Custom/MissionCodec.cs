using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for mission
/// </summary>
public class MissionCodec : CustomBaseCodec
{
    /// <summary>
    ///     Creates a new instance of MissionCodec
    /// </summary>
    private MissionCodec()
    {
    }

    /// <summary>
    ///     Gets the singleton instance of MissionCodec
    /// </summary>
    public static MissionCodec Instance { get; } = new();

    /// <summary>
    ///     Gets the list of attribute names for this codec
    /// </summary>
    protected override string[] Attributes => new[]
    {
        "freeChange",
        "description",
        "threshold",
        "image",
        "rewards",
        "progress",
        "missionID",
        "changeCost"
    };

    /// <summary>
    ///     Gets the list of codec objects for this codec
    /// </summary>
    protected override ICodec[] CodecObjects => new ICodec[]
    {
        BoolCodec.Instance,
        StringCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance,
        new VectorCodec(MissionRewardCodec.Instance, false),
        IntCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance
    };
}