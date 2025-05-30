using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for tank damage information
    /// </summary>
    public class TankDamageCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "damage",
            "damageType",
            "target"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.FloatCodec),
            typeof(Primitive.IntCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Creates a new instance of TankDamageCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public TankDamageCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 