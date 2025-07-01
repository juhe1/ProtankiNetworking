using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for social network entrance parameters.
    /// </summary>
    public class SocialNetworkEntranceParamsCodec : CustomBaseCodec
    {
        public static SocialNetworkEntranceParamsCodec Instance { get; } = new SocialNetworkEntranceParamsCodec();

        protected override string[] Attributes => new[] { "authorizationUrl", "snId" };
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
    }
} 