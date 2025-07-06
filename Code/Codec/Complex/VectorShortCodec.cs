using System;
using System.Collections.Generic;
using ProtankiNetworking.Utils;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Codec for vector of shorts
    /// </summary>
    public class VectorShortCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of VectorShortCodec
        /// </summary>
        public static VectorShortCodec Instance { get; } = new VectorShortCodec(ShortCodec.Instance);

        private readonly ICodec _shortCodec;

        /// <summary>
        /// Creates a new instance of VectorShortCodec
        /// </summary>
        /// <param name="shortCodec">The codec to use for short values</param>
        public VectorShortCodec(ICodec shortCodec)
        {
            _shortCodec = shortCodec;
        }

        /// <summary>
        /// Decodes a vector of shorts from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded vector of shorts</returns>
        public override object? Decode(EByteArray buffer)
        {
            var length = buffer.ReadInt();
            var result = new List<short>();
            for (int i = 0; i < length; i++)
            {
                result.Add((short)_shortCodec.Decode(buffer));
            }
            return result;
        }

        /// <summary>
        /// Encodes a vector of shorts to the buffer
        /// </summary>
        /// <param name="value">The vector of shorts to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object? value, EByteArray buffer)
        {
            if (value is not List<short> list)
            {
                throw new ArgumentException("Value must be a list of shorts", nameof(value));
            }

            var bytesWritten = 0;
            buffer.WriteInt(list.Count);
            bytesWritten += 4;

            foreach (var val in list)
            {
                bytesWritten += _shortCodec.Encode(val, buffer);
            }
            return bytesWritten;
        }
    }
} 