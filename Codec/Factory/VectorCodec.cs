using System;
using System.Collections.Generic;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Factory
{
    /// <summary>
    /// Factory for creating codecs that handle arrays of values
    /// </summary>
    /// <typeparam name="T">The type of values in the array</typeparam>
    public class VectorCodec<T> : BaseCodec<T[]>
    {
        private readonly BaseCodec<T> _elementCodec;

        /// <summary>
        /// Creates a new instance of VectorCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        /// <param name="elementCodec">The codec to use for individual elements</param>
        public VectorCodec(EByteArray buffer, BaseCodec<T> elementCodec) : base(buffer)
        {
            _elementCodec = elementCodec;
        }

        /// <summary>
        /// Decodes an array of values from the buffer
        /// </summary>
        /// <returns>The decoded array of values</returns>
        public override T[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<T>();

            var result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _elementCodec.Decode();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of values to the buffer
        /// </summary>
        /// <param name="value">The array of values to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(T[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }

            Buffer.WriteShort((short)value.Length);
            var totalBytes = 2;

            foreach (var item in value)
            {
                totalBytes += _elementCodec.Encode(item);
            }

            return totalBytes;
        }
    }
} 