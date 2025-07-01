using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for country information.
    /// </summary>
    public class CountryInfoCodec : CustomBaseCodec
    {
        public static CountryInfoCodec Instance { get; } = new CountryInfoCodec();

        protected override string[] Attributes => new[] { "countryCode", "countryName" };
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
    }
} 