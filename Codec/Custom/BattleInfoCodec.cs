using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for battle info information
    /// </summary>
    public class BattleInfoCodec : CustomBaseCodec
    {
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
            "serverNumber"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Complex.StringCodec),
            typeof(Complex.StringCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.BoolCodec),
            typeof(Primitive.BoolCodec),
            typeof(RankRangeCodec),
            typeof(Primitive.IntCodec)
        };

        /// <summary>
        /// Creates a new instance of BattleInfoCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BattleInfoCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 