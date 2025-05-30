using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for mission streak information
    /// </summary>
    public class MissionStreakCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "level",
            "streak",
            "doneToday",
            "questImgID",
            "rewardImgID"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.BoolCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec)
        };

        /// <summary>
        /// Creates a new instance of MissionStreakCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public MissionStreakCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 