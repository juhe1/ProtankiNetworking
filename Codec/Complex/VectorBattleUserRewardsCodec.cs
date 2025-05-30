using System;
using ProboTankiLibCS.Utils;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Codec.Complex
{
    /// <summary>
    /// Codec for arrays of BattleUserRewards values
    /// </summary>
    public class VectorBattleUserRewardsCodec : BaseCodec<Dictionary<string, object>[]>
    {
        private readonly BattleUserRewardsCodec _battleUserRewardsCodec;

        /// <summary>
        /// Creates a new instance of VectorBattleUserRewardsCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public VectorBattleUserRewardsCodec(EByteArray buffer) : base(buffer)
        {
            _battleUserRewardsCodec = new BattleUserRewardsCodec(buffer);
        }

        /// <summary>
        /// Decodes an array of BattleUserRewards values from the buffer
        /// </summary>
        /// <returns>The decoded array of BattleUserRewards values</returns>
        public override Dictionary<string, object>[] Decode()
        {
            var length = Buffer.ReadShort();
            if (length == 0)
                return Array.Empty<Dictionary<string, object>>();

            var result = new Dictionary<string, object>[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = _battleUserRewardsCodec.Decode();
            }
            return result;
        }

        /// <summary>
        /// Encodes an array of BattleUserRewards values to the buffer
        /// </summary>
        /// <param name="value">The array of BattleUserRewards values to encode</param>
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
            foreach (var rewards in value)
            {
                totalBytes += _battleUserRewardsCodec.Encode(rewards);
            }
            return totalBytes;
        }
    }
} 