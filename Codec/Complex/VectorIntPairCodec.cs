using System;
using System.Collections.Generic;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Represents a pair of integers.
    /// </summary>
    public struct IntPair
    {
        public int First { get; set; }
        public int Second { get; set; }
        public IntPair(int first, int second)
        {
            First = first;
            Second = second;
        }
    }

    /// <summary>
    /// Codec for vector of integer pairs
    /// </summary>
    public class VectorIntPairCodec : BaseCodec
    {
        private readonly ICodec _intCodec;

        /// <summary>
        /// Creates a new instance of VectorIntPairCodec
        /// </summary>
        /// <param name="intCodec">The codec to use for integer values</param>
        public VectorIntPairCodec(ICodec intCodec)
        {
            _intCodec = intCodec;
        }

        /// <summary>
        /// Decodes a vector of integer pairs from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded vector of integer pairs</returns>
        public override object Decode(EByteArray buffer)
        {
            var length = buffer.ReadInt();
            var result = new List<Tuple<object, object>>();
            for (int i = 0; i < length; i++)
            {
                var first = _intCodec.Decode(buffer);
                var second = _intCodec.Decode(buffer);
                result.Add(new Tuple<object, object>(first, second));
            }
            return result;
        }

        /// <summary>
        /// Encodes a vector of integer pairs to the buffer
        /// </summary>
        /// <param name="value">The vector of integer pairs to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not List<Tuple<object, object>> list)
            {
                throw new ArgumentException("Value must be a list of integer pairs", nameof(value));
            }

            var bytesWritten = 0;
            buffer.WriteInt(list.Count);
            bytesWritten += 4;

            foreach (var pair in list)
            {
                bytesWritten += _intCodec.Encode(pair.Item1, buffer);
                bytesWritten += _intCodec.Encode(pair.Item2, buffer);
            }
            return bytesWritten;
        }
    }
} 