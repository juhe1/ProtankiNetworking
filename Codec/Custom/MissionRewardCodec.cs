using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for mission reward information
    /// </summary>
    public class MissionRewardCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "amount",
            "name"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Creates a new instance of MissionRewardCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public MissionRewardCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 