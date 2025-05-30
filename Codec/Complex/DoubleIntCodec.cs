using ProboTankiLibCS.Utils;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for handling two integer values
    /// </summary>
    public class DoubleIntCodec : BaseCodec<(int, int)>
    {
        private readonly IntCodec _intCodec;

        /// <summary>
        /// Creates a new instance of DoubleIntCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public DoubleIntCodec(EByteArray buffer) : base(buffer)
        {
            _intCodec = new IntCodec(buffer);
        }

        /// <summary>
        /// Decodes two integer values from the buffer
        /// </summary>
        /// <returns>A tuple containing the two decoded integer values</returns>
        public override (int, int) Decode()
        {
            var value1 = _intCodec.Decode();
            var value2 = _intCodec.Decode();
            return (value1, value2);
        }

        /// <summary>
        /// Encodes two integer values to the buffer
        /// </summary>
        /// <param name="value">A tuple containing the two integer values to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode((int, int) value)
        {
            var bytes1 = _intCodec.Encode(value.Item1);
            var bytes2 = _intCodec.Encode(value.Item2);
            return bytes1 + bytes2;
        }
    }
} 