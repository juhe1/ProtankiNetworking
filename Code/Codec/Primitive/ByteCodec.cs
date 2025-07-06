using System;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Primitive
{
    /// <summary>
    /// Codec for byte values
    /// </summary>
    public class ByteCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of ByteCodec
        /// </summary>
        public static ByteCodec Instance { get; } = new ByteCodec();

        /// <summary>
        /// Creates a new instance of ByteCodec
        /// </summary>
        private ByteCodec()
        {
        }

        /// <summary>
        /// Decodes a byte value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded byte value</returns>
        public override object? Decode(EByteArray buffer)
        {
            return buffer.ReadByte();
        }

        /// <summary>
        /// Encodes a byte value to the buffer
        /// </summary>
        /// <param name="value">The byte value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object? value, EByteArray buffer)
        {
            if (value is not byte byteValue)
            {
                throw new ArgumentException("Value must be a byte", nameof(value));
            }
            buffer.WriteByte(byteValue);
            return 1;
        }
    }
} 