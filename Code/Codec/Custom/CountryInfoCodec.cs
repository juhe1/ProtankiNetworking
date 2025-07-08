using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for country information.
/// </summary>
public class CountryInfoCodec : CustomBaseCodec
{
    public static CountryInfoCodec Instance { get; } = new();

    protected override string[] Attributes => new[] { "countryCode", "countryName" };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance
    };
}