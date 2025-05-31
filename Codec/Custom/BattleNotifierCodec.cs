using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for battlenotifier
    /// </summary>
    public class BattleNotifierCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of BattleNotifierCodec
        /// </summary>
        public static BattleNotifierCodec Instance { get; } = new BattleNotifierCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "battleInfo",
            "username",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            BattleInfoCodec.Instance,
            StringCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of BattleNotifierCodec
        /// </summary>
        private BattleNotifierCodec() : base()
        {
        }
    }
}
