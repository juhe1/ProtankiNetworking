using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for battleinfo
    /// </summary>
    public class BattleInfoCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of BattleInfoCodec
        /// </summary>
        public static BattleInfoCodec Instance { get; } = new BattleInfoCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "battleID",
            "mapName",
            "mode",
            "private",
            "proBattle",
            "range",
            "serverNumber",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            BoolCodec.Instance,
            RankRangeCodec.Instance,
            IntCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of BattleInfoCodec
        /// </summary>
        private BattleInfoCodec() : base()
        {
        }
    }
}
