using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for battle notifier information
    /// </summary>
    public class BattleNotifierCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "battleInfo",
            "username"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(BattleInfoCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Creates a new instance of BattleNotifierCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public BattleNotifierCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 