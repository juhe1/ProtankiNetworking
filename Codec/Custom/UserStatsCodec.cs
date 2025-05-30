using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for user statistics information
    /// </summary>
    public class UserStatsCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "deaths",
            "kills",
            "score",
            "username"
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
        /// Creates a new instance of UserStatsCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public UserStatsCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 