using System;
using ProtankiNetworking.Utils;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for battleuserrewards
    /// </summary>
    public class BattleUserRewardsCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of BattleUserRewardsCodec
        /// </summary>
        public static BattleUserRewardsCodec Instance { get; } = new BattleUserRewardsCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "newbiesAbonementBonusReward",
            "premiumBonusReward",
            "reward",
            "userid",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            (ICodec)IntCodec.Instance,
            (ICodec)IntCodec.Instance,
            (ICodec)IntCodec.Instance,
            (ICodec)StringCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of BattleUserRewardsCodec
        /// </summary>
        private BattleUserRewardsCodec() : base()
        {
        }
    }
}
