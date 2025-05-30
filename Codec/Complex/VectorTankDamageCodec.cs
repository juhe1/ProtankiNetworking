using System;
using System.Collections.Generic;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of tank damage values
    /// </summary>
    public class VectorTankDamageCodec : BaseCodec<Dictionary<string, object>[]>
    {
        /// <summary>
        /// Creates a new instance of VectorTankDamageCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorTankDamageCodec(EByteArray buffer) : base(buffer)
        {
        }

        /// <summary>
        /// Decodes an array of tank damage values from the buffer
        /// </summary>
        /// <returns>The decoded array of tank damage values</returns>
        public override Dictionary<string, object>[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<Dictionary<string, object>>();

            var result = new Dictionary<string, object>[length];
            var codec = new TankDamageCodec(Buffer);
            for (int i = 0; i < length; i++)
            {
                result[i] = codec.Decode();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of tank damage values to the buffer
        /// </summary>
        /// <param name="value">The array of tank damage values to encode</param>
        /// <returns>The number of bytes written</returns>
        public override int Encode(Dictionary<string, object>[] value)
        {
            if (value == null || value.Length == 0)
            {
                Buffer.WriteShort(0);
                return 2;
            }

            Buffer.WriteShort((short)value.Length);
            var totalBytes = 2;
            var codec = new TankDamageCodec(Buffer);
            foreach (var val in value)
            {
                totalBytes += codec.Encode(val);
            }
            return totalBytes;
        }
    }
} 