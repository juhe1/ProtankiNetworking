using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Primitive
{
    /// <summary>
    /// Codec for boolean values
    /// </summary>
    public class BoolCodec : BaseCodec<bool>
    {
        /// <summary>
        /// Creates a new instance of BoolCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BoolCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes a boolean value from the buffer
        /// </summary>
        /// <returns>The decoded boolean value</returns>
        public override bool Decode()
        {
            return BoolShorten ? Buffer.ReadByte() != 0 : Buffer.ReadBoolean();
        }

        /// <summary>
        /// Encodes a boolean value to the buffer
        /// </summary>
        /// <param name="value">The boolean value to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(bool value)
        {
            if (BoolShorten)
            {
                Buffer.WriteByte((byte)(value ? 1 : 0));
                return 1;
            }
            else
            {
                Buffer.WriteBoolean(value);
                return 1;
            }
        }
    }
} 