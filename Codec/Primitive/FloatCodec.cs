using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Primitive
{
    /// <summary>
    /// Codec for float values
    /// </summary>
    public class FloatCodec : BaseCodec<float>
    {
        /// <summary>
        /// Creates a new instance of FloatCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public FloatCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a float value from the buffer
        /// </summary>
        /// <returns>The decoded float value</returns>
        public override float Decode()
        {
            return Buffer.ReadFloat();
        }

        /// <summary>
        /// Encodes a float value to the buffer
        /// </summary>
        /// <param name="value">The float value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(float value)
        {
            Buffer.WriteFloat(value);
            return 4;
        }
    }
} 