using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for movement information
    /// </summary>
    public class MoveCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "angV",
            "control",
            "linV",
            "orientation",
            "pos"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Complex.Vector3DCodec),
            typeof(Primitive.ByteCodec),
            typeof(Complex.Vector3DCodec),
            typeof(Complex.Vector3DCodec),
            typeof(Complex.Vector3DCodec)
        };

        /// <summary>
        /// Creates a new instance of MoveCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public MoveCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 