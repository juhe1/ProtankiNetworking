using System;
using System.Collections.Generic;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Factory
{
    /// <summary>
    /// Factory for creating codecs that can handle multiple types
    /// </summary>
    public class MultiTypeCodec : BaseCodec<object>
    {
        private readonly Dictionary<Type, BaseCodec<object>> _codecs;
        private readonly BaseCodec<byte> _typeCodec;

        /// <summary>
        /// Creates a new instance of MultiTypeCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        /// <param name="codecs">Dictionary mapping types to their codecs</param>
        public MultiTypeCodec(EByteArray buffer, Dictionary<Type, BaseCodec<object>> codecs) : base(buffer)
        {
            _codecs = codecs;
            _typeCodec = new Primitive.ByteCodec(buffer);
        }

        /// <summary>
        /// Decodes a value from the buffer
        /// </summary>
        /// <returns>The decoded value</returns>
        public override object Decode()
        {
            var typeIndex = _typeCodec.Decode();
            var type = GetTypeFromIndex(typeIndex);
            
            if (!_codecs.TryGetValue(type, out var codec))
                throw new InvalidOperationException($"No codec found for type index {typeIndex}");

            return codec.Decode();
        }

        /// <summary>
        /// Encodes a value to the buffer
        /// </summary>
        /// <param name="value">The value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var type = value.GetType();
            if (!_codecs.TryGetValue(type, out var codec))
                throw new InvalidOperationException($"No codec found for type {type}");

            var typeIndex = GetIndexFromType(type);
            var bytesWritten = _typeCodec.Encode(typeIndex);
            bytesWritten += codec.Encode(value);

            return bytesWritten;
        }

        private byte GetIndexFromType(Type type)
        {
            byte index = 0;
            foreach (var key in _codecs.Keys)
            {
                if (key == type)
                    return index;
                index++;
            }
            throw new InvalidOperationException($"Type {type} not found in codec dictionary");
        }

        private Type GetTypeFromIndex(byte index)
        {
            var types = new List<Type>(_codecs.Keys);
            if (index >= types.Count)
                throw new InvalidOperationException($"Invalid type index {index}");
            return types[index];
        }
    }
} 