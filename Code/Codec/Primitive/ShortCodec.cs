using System;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Primitive
{
    /// <summary>
    /// Codec for short values
    /// </summary>
    public class ShortCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of ShortCodec
        /// </summary>
        public static ShortCodec Instance { get; } = new ShortCodec();

        /// <summary>
        /// Creates a new instance of ShortCodec
        /// </summary>
        private ShortCodec()
        {
        }

        /// <summary>
        /// Decodes a short value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded short value</returns>
        public override object Decode(EByteArray buffer)
        {
            return buffer.ReadShort();
        }

        /// <summary>
        /// Encodes a short value to the buffer
        /// </summary>
        /// <param name="value">The short value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not short shortValue)
            {
                throw new ArgumentException("Value must be a short", nameof(value));
            }
            buffer.WriteShort(shortValue);
            return 2;
        }
    }
} 