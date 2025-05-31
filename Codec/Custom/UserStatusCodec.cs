using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for userstatus
    /// </summary>
    public class UserStatusCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of UserStatusCodec
        /// </summary>
        public static UserStatusCodec Instance { get; } = new UserStatusCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "modLevel",
            "ip",
            "rank",
            "username",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            IntCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of UserStatusCodec
        /// </summary>
        private UserStatusCodec() : base()
        {
        }
    }
}
