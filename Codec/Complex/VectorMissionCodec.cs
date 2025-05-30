using System;
using ProboTankiLibCS.Utils;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of Mission values
    /// </summary>
    public class VectorMissionCodec : BaseCodec<Dictionary<string, object>[]>
    {
        private readonly MissionCodec _missionCodec;

        /// <summary>
        /// Creates a new instance of VectorMissionCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorMissionCodec(EByteArray buffer) : base(buffer)
        {
            _missionCodec = new MissionCodec(buffer);
        }

        /// <summary>
        /// Decodes an array of Mission values from the buffer
        /// </summary>
        /// <returns>The decoded array of Mission values</returns>
        public override Dictionary<string, object>[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<Dictionary<string, object>>();

            var result = new Dictionary<string, object>[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _missionCodec.Decode();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of Mission values to the buffer
        /// </summary>
        /// <param name="value">The array of Mission values to encode</param>
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
            foreach (var mission in value)
            {
                totalBytes += _missionCodec.Encode(mission);
            }
            return totalBytes;
        }
    }
} 