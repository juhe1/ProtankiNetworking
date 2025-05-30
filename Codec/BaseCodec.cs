using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec
{
    /// <summary>
    /// Base class for all codecs, whether primitive or complex
    /// </summary>
    /// <typeparam name="T">The type that this codec handles</typeparam>
    public abstract class BaseCodec<T>
    {
        /// <summary>
        /// Gets or sets whether to use shortened boolean encoding
        /// </summary>
        public virtual bool BoolShorten { get; set; } = false;

        /// <summary>
        /// Gets the buffer used for encoding/decoding
        /// </summary>
        protected EByteArray Buffer { get; }

        /// <summary>
        /// Creates a new instance of BaseCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        protected BaseCodec(EByteArray buffer)
        {
            Buffer = buffer;
        }

        /// <summary>
        /// Decodes a value from the buffer
        /// </summary>
        /// <returns>The decoded value</returns>
        public abstract T Decode();

        /// <summary>
        /// Encodes a value to the buffer
        /// </summary>
        /// <param name="value">The value to encode</param>
        /// <returns>The number of bytes written</returns>
        public abstract int Encode(T value);
    }
} 