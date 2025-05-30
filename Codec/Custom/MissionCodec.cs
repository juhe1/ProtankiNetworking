using System;
using System.Collections.Generic;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for mission information
    /// </summary>
    public class MissionCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "freeChange",
            "description",
            "threshold",
            "image",
            "rewards",
            "progress",
            "missionID",
            "changeCost"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.BoolCodec),
            typeof(Complex.StringCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Factory.VectorCodec<Dictionary<string, object>>),
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec)
        };

        /// <summary>
        /// Creates a new instance of MissionCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public MissionCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 