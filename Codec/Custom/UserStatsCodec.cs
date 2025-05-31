using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for userstats
    /// </summary>
    public class UserStatsCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of UserStatsCodec
        /// </summary>
        public static UserStatsCodec Instance { get; } = new UserStatsCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "deaths",
            "kills",
            "score",
            "username",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            IntCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of UserStatsCodec
        /// </summary>
        private UserStatsCodec() : base()
        {
        }
    }
}
