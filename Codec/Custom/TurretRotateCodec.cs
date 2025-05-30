using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for turret rotation information
    /// </summary>
    public class TurretRotateCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "angle",
            "control"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.FloatCodec),
            typeof(Primitive.ByteCodec)
        };

        /// <summary>
        /// Creates a new instance of TurretRotateCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public TurretRotateCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 