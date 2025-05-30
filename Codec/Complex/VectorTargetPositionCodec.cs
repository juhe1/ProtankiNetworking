using System;
using ProboTankiLibCS.Utils;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of TargetPosition values
    /// </summary>
    public class VectorTargetPositionCodec : BaseCodec<Dictionary<string, object>[]>
    {
        private readonly TargetPositionCodec _targetPositionCodec;

        /// <summary>
        /// Creates a new instance of VectorTargetPositionCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorTargetPositionCodec(EByteArray buffer) : base(buffer)
        {
            _targetPositionCodec = new TargetPositionCodec(buffer);
        }

        /// <summary>
        /// Decodes an array of TargetPosition values from the buffer
        /// </summary>
        /// <returns>The decoded array of TargetPosition values</returns>
        public override Dictionary<string, object>[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<Dictionary<string, object>>();

            var result = new Dictionary<string, object>[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _targetPositionCodec.Decode();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of TargetPosition values to the buffer
        /// </summary>
        /// <param name="value">The array of TargetPosition values to encode</param>
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
            foreach (var targetPosition in value)
            {
                totalBytes += _targetPositionCodec.Encode(targetPosition);
            }
            return totalBytes;
        }
    }
} 