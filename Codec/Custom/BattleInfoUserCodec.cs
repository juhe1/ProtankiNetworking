using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for battle info user information
    /// </summary>
    public class BattleInfoUserCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "kills",
            "score",
            "suspicious",
            "user"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.BoolCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Gets whether to use boolean short form
        /// </summary>
        protected override bool BoolShorten => false;

        /// <summary>
        /// Creates a new instance of BattleInfoUserCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BattleInfoUserCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 