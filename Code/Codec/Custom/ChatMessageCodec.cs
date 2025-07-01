using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for chatmessage
    /// </summary>
    public class ChatMessageCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of ChatMessageCodec
        /// </summary>
        public static ChatMessageCodec Instance { get; } = new ChatMessageCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "authorStatus",
            "systemMessage",
            "targetStatus",
            "message",
            "warning",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            UserStatusCodec.Instance,
            BoolCodec.Instance,
            UserStatusCodec.Instance,
            StringCodec.Instance,
            BoolCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of ChatMessageCodec
        /// </summary>
        private ChatMessageCodec() : base()
        {
        }
    }
}
