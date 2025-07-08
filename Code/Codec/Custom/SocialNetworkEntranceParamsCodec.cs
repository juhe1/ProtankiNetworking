using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for social network entrance parameters.
/// </summary>
public class SocialNetworkEntranceParamsCodec : CustomBaseCodec
{
    public static SocialNetworkEntranceParamsCodec Instance { get; } = new();

    protected override string[] Attributes => new[] { "authorizationUrl", "snId" };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance
    };
}