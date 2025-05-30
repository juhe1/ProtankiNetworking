using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of short values
    /// </summary>
    public class VectorShortCodec : BaseCodec<short[]>
    {
        /// <summary>
        /// Creates a new instance of VectorShortCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorShortCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes an array of short values from the buffer
        /// </summary>
        /// <returns>The decoded array of short values</returns>
        public override short[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<short>();

            var result = new short[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = Buffer.ReadShort();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of short values to the buffer
        /// </summary>
        /// <param name="value">The array of short values to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(short[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }

            Buffer.WriteShort((short)value.Length);
            var totalBytes = 2;
            foreach (var val in value)
            {
                Buffer.WriteShort(val);
                totalBytes += 2;
            }
            return totalBytes;
        }
    }
} 