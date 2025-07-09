using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
/// Codec for SocialNetworkPanelParams (authorizationUrl, linkExists, snId).
/// </summary>
public class SocialNetworkPanelParamsCodec : CustomBaseCodec
{
    public static SocialNetworkPanelParamsCodec Instance { get; } = new SocialNetworkPanelParamsCodec();

    protected override string[] Attributes => new[]
    {
        "authorizationUrl",
        "linkExists",
        "snId"
    };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        StringCodec.Instance, // authorizationUrl
        BoolCodec.Instance,   // linkExists
        StringCodec.Instance  // snId
    };
} 