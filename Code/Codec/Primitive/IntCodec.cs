using System;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Primitive
{
    /// <summary>
    /// Codec for integer values
    /// </summary>
    public class IntCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of IntCodec
        /// </summary>
        public static IntCodec Instance { get; } = new IntCodec();

        /// <summary>
        /// Creates a new instance of IntCodec
        /// </summary>
        private IntCodec()
        {
        }

        /// <summary>
        /// Decodes an integer value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded integer value</returns>
        public override object? Decode(EByteArray buffer)
        {
            return buffer.ReadInt();
        }

        /// <summary>
        /// Encodes an integer value to the buffer
        /// </summary>
        /// <param name="value">The integer value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object? value, EByteArray buffer)
        {
            if (value is not int intValue)
            {
                throw new ArgumentException("Value must be an integer", nameof(value));
            }
            buffer.WriteInt(intValue);
            return 4;
        }
    }
} 