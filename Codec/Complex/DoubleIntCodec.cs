using System;
using ProtankiNetworking.Utils;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Complex
{
    /// <summary>
    /// Codec for double integer values
    /// </summary>
    public class DoubleIntCodec : BaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of DoubleIntCodec
        /// </summary>
        public static DoubleIntCodec Instance { get; } = new DoubleIntCodec(IntCodec.Instance);

        private readonly ICodec _intCodec;

        /// <summary>
        /// Creates a new instance of DoubleIntCodec
        /// </summary>
        /// <param name="intCodec">The codec to use for integer values</param>
        public DoubleIntCodec(ICodec intCodec)
        {
            _intCodec = intCodec;
        }

        /// <summary>
        /// Decodes a double integer value from the buffer
        /// </summary>
        /// <param name="buffer">The buffer to decode from</param>
        /// <returns>The decoded double integer value</returns>
        public override object Decode(EByteArray buffer)
        {
            var first = _intCodec.Decode(buffer);
            var second = _intCodec.Decode(buffer);
            return new Tuple<object, object>(first, second);
        }

        /// <summary>
        /// Encodes a double integer value to the buffer
        /// </summary>
        /// <param name="value">The double integer value to encode</param>
        /// <param name="buffer">The buffer to encode to</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(object value, EByteArray buffer)
        {
            if (value is not Tuple<object, object> tuple)
            {
                throw new ArgumentException("Value must be a tuple of two objects", nameof(value));
            }

            var bytesWritten = 0;
            bytesWritten += _intCodec.Encode(tuple.Item1, buffer);
            bytesWritten += _intCodec.Encode(tuple.Item2, buffer);
            return bytesWritten;
        }
    }
} 