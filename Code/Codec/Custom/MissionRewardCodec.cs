using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for missionreward
/// </summary>
public class MissionRewardCodec : CustomBaseCodec
{
    /// <summary>
    ///     Creates a new instance of MissionRewardCodec
    /// </summary>
    private MissionRewardCodec()
    {
    }

    /// <summary>
    ///     Gets the singleton instance of MissionRewardCodec
    /// </summary>
    public static MissionRewardCodec Instance { get; } = new();

    /// <summary>
    ///     Gets the list of attribute names for this codec
    /// </summary>
    protected override string[] Attributes => new[]
    {
        "amount",
        "name"
    };

    /// <summary>
    ///     Gets the list of codec objects for this codec
    /// </summary>
    protected override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance,
        StringCodec.Instance
    };
}