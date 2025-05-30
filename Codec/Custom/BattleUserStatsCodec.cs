using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for battle user statistics information
    /// </summary>
    public class BattleUserStatsCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "deaths",
            "kills",
            "score",
            "user"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Creates a new instance of BattleUserStatsCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BattleUserStatsCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 