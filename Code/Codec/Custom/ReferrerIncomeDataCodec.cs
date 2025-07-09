using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for ReferrerIncomeData (income, user).
    /// </summary>
    public class ReferrerIncomeDataCodec : CustomBaseCodec
    {
        public static ReferrerIncomeDataCodec Instance { get; } = new ReferrerIncomeDataCodec();

        protected override string[] Attributes => new[]
        {
            "income",
            "user"
        };

        protected override ICodec[] CodecObjects => new ICodec[]
        {
            IntCodec.Instance, // income
            StringCodec.Instance // user
        };
    }
} 