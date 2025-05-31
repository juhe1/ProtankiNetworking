using System;
using System.Collections.Generic;
using ProtankiNetworking.Utils;
using ProtankiNetworking.Codec.Primitive;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Base class for custom codecs that handle specific data structures
    /// </summary>
    public abstract class CustomBaseCodec : BaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected abstract string[] Attributes { get; }

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected abstract ICodec[] CodecObjects { get; }

        /// <summary>
        /// Creates a new instance of CustomBaseCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        protected CustomBaseCodec() : base()
        {
        }

        /// <summary>
        /// Decodes a value from the buffer
        /// </summary>
        /// <returns>The decoded value</returns>
        public override object Decode(EByteArray buffer)
        {
            var result = new Dictionary<string, object>();

            if (BoolShorten)
            {
                if ((bool)BoolCodec.Instance.Decode(buffer))
                {
                    return result;
                }
            }

            for (int i = 0; i < CodecObjects.Length; i++)
            {
                var attributeName = Attributes[i];
                var codec = CodecObjects[i];
                var decodedValue = codec.Decode(buffer);
                result[attributeName] = decodedValue;
            }

            return result;
        }

        /// <summary>
        /// Encodes a value to the buffer
        /// </summary>
        /// <param name="value">The value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not Dictionary<string, object> dict)
            {
                throw new ArgumentException("Value must be a Dictionary<string, object>", nameof(value));
            }

            var bytesWritten = 0;

            if (BoolShorten)
            {
                bytesWritten += BoolCodec.Instance.Encode(dict == null, buffer);
                if (dict == null)
                {
                    return bytesWritten;
                }
            }

            for (int i = 0; i < CodecObjects.Length; i++)
            {
                var attributeName = Attributes[i];
                var codec = CodecObjects[i];
                bytesWritten += codec.Encode(dict[attributeName], buffer);
            }

            return bytesWritten;
        }
    }
} 