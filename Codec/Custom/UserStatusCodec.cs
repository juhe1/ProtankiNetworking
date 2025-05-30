using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for user status information
    /// </summary>
    public class UserStatusCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "modLevel",
            "ip",
            "rank",
            "username"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(Primitive.IntCodec),
            typeof(Complex.StringCodec),
            typeof(Primitive.IntCodec),
            typeof(Complex.StringCodec)
        };

        /// <summary>
        /// Gets whether to use boolean short form
        /// </summary>
        protected override bool BoolShorten => true;

        /// <summary>
        /// Creates a new instance of UserStatusCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public UserStatusCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 