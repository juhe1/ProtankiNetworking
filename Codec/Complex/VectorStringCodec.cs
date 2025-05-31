using System;
using System.Collections.Generic;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Codec for vector of strings
    /// </summary>
    public class VectorStringCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of VectorStringCodec
        /// </summary>
        public static VectorStringCodec Instance { get; } = new VectorStringCodec(StringCodec.Instance);

        private readonly ICodec _stringCodec;

        /// <summary>
        /// Creates a new instance of VectorStringCodec
        /// </summary>
        /// <param name="stringCodec">The codec to use for string values</param>
        public VectorStringCodec(ICodec stringCodec)
        {
            _stringCodec = stringCodec;
        }

        /// <summary>
        /// Decodes a vector of strings from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded vector of strings</returns>
        public override object Decode(EByteArray buffer)
        {
            var length = buffer.ReadInt();
            var result = new List<string>();
            for (int i = 0; i < length; i++)
            {
                result.Add((string)_stringCodec.Decode(buffer));
            }
            return result;
        }

        /// <summary>
        /// Encodes a vector of strings to the buffer
        /// </summary>
        /// <param name="value">The vector of strings to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not List<string> list)
            {
                throw new ArgumentException("Value must be a list of strings", nameof(value));
            }

            var bytesWritten = 0;
            buffer.WriteInt(list.Count);
            bytesWritten += 4;

            foreach (var str in list)
            {
                bytesWritten += _stringCodec.Encode(str, buffer);
            }
            return bytesWritten;
        }
    }
} 