using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Primitive
{
    /// <summary>
    /// Codec for byte values
    /// </summary>
    public class ByteCodec : BaseCodec<byte>
    {
        /// <summary>
        /// Creates a new instance of ByteCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public ByteCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a byte value from the buffer
        /// </summary>
        /// <returns>The decoded byte value</returns>
        public override byte Decode()
        {
            return Buffer.ReadByte();
        }

        /// <summary>
        /// Encodes a byte value to the buffer
        /// </summary>
        /// <param name="value">The byte value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(byte value)
        {
            Buffer.WriteByte(value);
            return 1;
        }
    }
} 