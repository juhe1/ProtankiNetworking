using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for battle user rewards information
    /// </summary>
    public class BattleUserRewardsCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "newbiesAbonementBonusReward",
            "premiumBonusReward",
            "reward",
            "userid"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Creates a new instance of BattleUserRewardsCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BattleUserRewardsCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 