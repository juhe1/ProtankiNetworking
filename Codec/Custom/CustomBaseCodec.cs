using System;
using System.Collections.Generic;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Base class for custom codecs that handle specific data structures
    /// </summary>
    public abstract class CustomBaseCodec : BaseCodec<Dictionary<string, object>>
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected abstract string[] Attributes { get; }

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected abstract Type[] CodecTypes { get; }

        /// <summary>
        /// Gets whether to use boolean short form. Default is false.
        /// </summary>
        protected virtual bool BoolShorten => false;

        /// <summary>
        /// Creates a new instance of CustomBaseCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        protected CustomBaseCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a value from the buffer
        /// </summary>
        /// <returns>The decoded value</returns>
        public override Dictionary<string, object> Decode()
        {
            var result = new Dictionary<string, object>();

            if (BoolShorten)
            {
                var boolCodec = new Primitive.BoolCodec(Buffer);
                if (boolCodec.Decode())
                {
                    return result;
                }
            }

            for (int i = 0; i < CodecTypes.Length; i++)
            {
                var attributeName = Attributes[i];
                var codecType = CodecTypes[i];
                var codec = (BaseCodec<object>)Activator.CreateInstance(codecType, Buffer);
                var decodedValue = codec.Decode();
                result[attributeName] = decodedValue;
            }

            return result;
        }

        /// <summary>
        /// Encodes a value to the buffer
        /// </summary>
        /// <param name="value">The value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(Dictionary<string, object> value)
        {
            var bytesWritten = 0;

            if (BoolShorten)
            {
                var boolCodec = new Primitive.BoolCodec(Buffer);
                bytesWritten += boolCodec.Encode(value == null);
                if (value == null)
                {
                    return bytesWritten;
                }
            }

            for (int i = 0; i < CodecTypes.Length; i++)
            {
                var attributeName = Attributes[i];
                var codecType = CodecTypes[i];
                var codec = (BaseCodec<object>)Activator.CreateInstance(codecType, Buffer);
                bytesWritten += codec.Encode(value[attributeName]);
            }

            return bytesWritten;
        }
    }
} 