using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for battle user information
    /// </summary>
    public class BattleUserCodec : CustomBaseCodec
    {
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
            "username"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.IntCodec),
            typeof(Primitive.ByteCodec),
            typeof(Primitive.IntCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Creates a new instance of BattleUserCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BattleUserCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 