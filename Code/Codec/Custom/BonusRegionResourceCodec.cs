using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for BonusRegionResource structure used in bonus regions configuration.
/// </summary>
public class BonusRegionResourceCodec : CustomBaseCodec
{
    public static BonusRegionResourceCodec Instance { get; } = new();

    protected override string[] Attributes => new[]
    {
        "dropZoneResource",
        "regionType"
    };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance, // dropZoneResource (ResourceGetterCodec)
        BonusesTypeCodec.Instance // regionType
    };
}