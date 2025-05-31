using System;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec
{
    /// <summary>
    /// Base class for all codecs, whether primitive or complex
    /// </summary>
    public abstract class BaseCodec : ICodec
    {
        /// <summary>
        /// Gets or sets whether to use shortened boolean encoding
        /// </summary>
        public virtual bool BoolShorten { get; set; } = false;

        /// <summary>
        /// Creates a new instance of BaseCodec
        /// </summary>
        protected BaseCodec()
        {
        }

        /// <summary>
        /// Decodes a value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded value</returns>
        public abstract object Decode(EByteArray buffer);

        /// <summary>
        /// Encodes a value to the buffer
        /// </summary>
        /// <param name="value">The value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public abstract int Encode(object value, EByteArray buffer);
    }
} 