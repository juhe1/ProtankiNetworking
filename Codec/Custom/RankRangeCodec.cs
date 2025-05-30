using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for rank range information
    /// </summary>
    public class RankRangeCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "maxRank",
            "minRank"
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
        /// Creates a new instance of RankRangeCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public RankRangeCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 