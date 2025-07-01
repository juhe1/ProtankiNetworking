using System;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec
{
    /// <summary>
    /// Interface for all codecs
    /// </summary>
    public interface ICodec
    {
        /// <summary>
        /// Gets or sets whether to use shortened boolean encoding
        /// </summary>
        bool BoolShorten { get; set; }

        /// <summary>
        /// Decodes a value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded value</returns>
        object Decode(EByteArray buffer);

        /// <summary>
        /// Encodes a value to the buffer
        /// </summary>
        /// <param name="value">The value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        int Encode(object value, EByteArray buffer);
    }
} 