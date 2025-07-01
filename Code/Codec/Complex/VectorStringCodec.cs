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
        public static VectorStringCodec Instance { get; } = new VectorStringCodec();

        private static VectorCodec codec = new VectorCodec(StringCodec.Instance, true);

        /// <summary>
        /// Creates a new instance of VectorStringCodec
        /// </summary>
        /// <param name="stringCodec">The codec to use for string values</param>
        public VectorStringCodec()
        {
        }

        /// <summary>
        /// Decodes a vector of strings from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded vector of strings</returns>
        public override object Decode(EByteArray buffer)
        {
            return codec.Decode(buffer);
        }

        /// <summary>
        /// Encodes a vector of strings to the buffer
        /// </summary>
        /// <param name="value">The vector of strings to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            return codec.Encode(value, buffer);
        }
    }
} 