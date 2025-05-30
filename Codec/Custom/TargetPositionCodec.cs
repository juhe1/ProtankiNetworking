using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for target position information
    /// </summary>
    public class TargetPositionCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "localHitPoint",
            "orientation",
            "position",
            "target",
            "turretAngle"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Complex.Vector3DCodec),
            typeof(Complex.Vector3DCodec),
            typeof(Complex.Vector3DCodec),
            typeof(Complex.StringCodec),
            typeof(Primitive.FloatCodec)
        };

        /// <summary>
        /// Creates a new instance of TargetPositionCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public TargetPositionCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 