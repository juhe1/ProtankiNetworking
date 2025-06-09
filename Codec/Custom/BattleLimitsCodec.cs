using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for battle limits
    /// </summary>
    public class BattleLimitsCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of BattleLimitsCodec
        /// </summary>
        public static BattleLimitsCodec Instance { get; } = new BattleLimitsCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "scoreLimit",
            "timeLimit",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            IntCodec.Instance,
            IntCodec.Instance
        };

        /// <summary>
        /// Creates a new instance of BattleLimitsCodec
        /// </summary>
        private BattleLimitsCodec() : base()
        {
        }
    }
}
