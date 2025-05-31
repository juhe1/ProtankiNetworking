using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for battleuser
    /// </summary>
    public class BattleUserCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of BattleUserCodec
        /// </summary>
        public static BattleUserCodec Instance { get; } = new BattleUserCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "modLevel",
            "deaths",
            "kills",
            "rank",
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
            ByteCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of BattleUserCodec
        /// </summary>
        private BattleUserCodec() : base()
        {
        }
    }
}
