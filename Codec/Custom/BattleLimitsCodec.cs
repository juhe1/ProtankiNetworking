using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for battle limits information
    /// </summary>
    public class BattleLimitsCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "scoreLimit",
            "timeLimit"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec)
        };

        /// <summary>
        /// Creates a new instance of BattleLimitsCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BattleLimitsCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 