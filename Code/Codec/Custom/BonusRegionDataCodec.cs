using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for BonusRegionData (position, rotation, regionType).
/// </summary>
public class BonusRegionDataCodec : CustomBaseCodec
{
    public static BonusRegionDataCodec Instance { get; } = new();

    protected override string[] Attributes => new[]
    {
        "position",
        "rotation",
        "regionType"
    };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        Vector3DCodec.Instance, // position
        Vector3DCodec.Instance, // rotation
        BonusesTypeCodec.Instance // regionType
    };
}