using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Primitive
{
    /// <summary>
    /// Codec for integer values
    /// </summary>
    public class IntCodec : BaseCodec<int>
    {
        /// <summary>
        /// Creates a new instance of IntCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public IntCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes an integer value from the buffer
        /// </summary>
        /// <returns>The decoded integer value</returns>
        public override int Decode()
        {
            return Buffer.ReadInt();
        }

        /// <summary>
        /// Encodes an integer value to the buffer
        /// </summary>
        /// <param name="value">The integer value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(int value)
        {
            Buffer.WriteInt(value);
            return 4;
        }
    }
} 