using System;
using System.Collections.Generic;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Codec for vector values
    /// </summary>
    public class VectorCodec : BaseCodec
    {
        private readonly ICodec _elementCodec;
        private readonly bool _shorten;

        /// <summary>
        /// Creates a new instance of VectorCodec
        /// </summary>
        /// <param name="elementCodec">The codec to use for vector elements</param>
        /// <param name="shorten">Whether to use shortened encoding</param>
        public VectorCodec(ICodec elementCodec, bool shorten = false)
        {
            _elementCodec = elementCodec;
            _shorten = shorten;
        }

        /// <summary>
        /// Decodes a vector value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded vector value</returns>
        public override object Decode(EByteArray buffer)
        {
            int length;
            if (_shorten)
            {
                length = buffer.ReadByte();
            }
            else
            {
                length = buffer.ReadInt();
            }

            var result = new List<object>();
            for (int i = 0; i < length; i++)
            {
                result.Add(_elementCodec.Decode(buffer));
            }
            return result;
        }

        /// <summary>
        /// Encodes a vector value to the buffer
        /// </summary>
        /// <param name="value">The vector value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not List<object> list)
            {
                throw new ArgumentException("Value must be a list", nameof(value));
            }

            int bytesWritten = 0;
            if (_shorten)
            {
                buffer.WriteByte((byte)list.Count);
                bytesWritten += 1;
            }
            else
            {
                buffer.WriteInt(list.Count);
                bytesWritten += 4;
            }

            foreach (var item in list)
            {
                bytesWritten += _elementCodec.Encode(item, buffer);
            }
            return bytesWritten;
        }
    }
} 