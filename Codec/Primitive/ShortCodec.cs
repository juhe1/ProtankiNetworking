using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Primitive
{
    /// <summary>
    /// Codec for short values
    /// </summary>
    public class ShortCodec : BaseCodec<short>
    {
        /// <summary>
        /// Creates a new instance of ShortCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public ShortCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a short value from the buffer
        /// </summary>
        /// <returns>The decoded short value</returns>
        public override short Decode()
        {
            return Buffer.ReadShort();
        }

        /// <summary>
        /// Encodes a short value to the buffer
        /// </summary>
        /// <param name="value">The short value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(short value)
        {
            Buffer.WriteShort(value);
            return 2;
        }
    }
} 