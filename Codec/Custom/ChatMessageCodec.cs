using System;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Codec.Custom
{
    /// <summary>
    /// Codec for chat messages
    /// </summary>
    public class ChatMessageCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "authorStatus",
            "systemMessage",
            "targetStatus",
            "message",
            "warning"
        };

        /// <summary>
        /// Gets the list of codec types for this codec
        /// </summary>
        protected override Type[] CodecTypes => new[]
        {
            typeof(UserStatusCodec),
            typeof(Primitive.BoolCodec),
            typeof(UserStatusCodec),
            typeof(Complex.StringCodec),
            typeof(Primitive.BoolCodec)
        };

        /// <summary>
        /// Creates a new instance of ChatMessageCodec
        /// </summary>
        /// <param name="buffer">The buffer to use for encoding/decoding</param>
        public ChatMessageCodec(EByteArray buffer) : base(buffer)
        {
        }
    }
} 