using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for move
    /// </summary>
    public class MoveCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of MoveCodec
        /// </summary>
        public static MoveCodec Instance { get; } = new MoveCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "angV",
            "control",
            "linV",
            "orientation",
            "pos",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            Vector3DCodec.Instance,
            ByteCodec.Instance,
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of MoveCodec
        /// </summary>
        private MoveCodec() : base()
        {
        }
    }
}
