using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of integer values
    /// </summary>
    public class VectorIntCodec : BaseCodec<int[]>
    {
        /// <summary>
        /// Creates a new instance of VectorIntCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorIntCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes an array of integer values from the buffer
        /// </summary>
        /// <returns>The decoded array of integer values</returns>
        public override int[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<int>();

            var result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = Buffer.ReadInt();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of integer values to the buffer
        /// </summary>
        /// <param name="value">The array of integer values to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(int[] value)
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
                Buffer.WriteInt(val);
                totalBytes += 4;
            }
            return totalBytes;
        }
    }
} 