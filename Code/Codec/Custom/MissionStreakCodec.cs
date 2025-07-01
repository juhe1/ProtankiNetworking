using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for missionstreak
    /// </summary>
    public class MissionStreakCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of MissionStreakCodec
        /// </summary>
        public static MissionStreakCodec Instance { get; } = new MissionStreakCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "level",
            "streak",
            "doneToday",
            "questImgID",
            "rewardImgID",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            IntCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of MissionStreakCodec
        /// </summary>
        private MissionStreakCodec() : base()
        {
        }
    }
}
