using System;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Primitive
{
    /// <summary>
    /// Codec for boolean values
    /// </summary>
    public class BoolCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of BoolCodec
        /// </summary>
        public static BoolCodec Instance { get; } = new BoolCodec();

        /// <summary>
        /// Creates a new instance of BoolCodec
        /// </summary>
        private BoolCodec()
        {
        }

        /// <summary>
        /// Decodes a boolean value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded boolean value</returns>
        public override object Decode(EByteArray buffer)
        {
            return buffer.ReadBoolean();
        }

        /// <summary>
        /// Encodes a boolean value to the buffer
        /// </summary>
        /// <param name="value">The boolean value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not bool boolValue)
            {
                throw new ArgumentException("Value must be a boolean", nameof(value));
            }
            buffer.WriteBoolean(boolValue);
            return 1;
        }
    }
} 