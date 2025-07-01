using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for targetposition
    /// </summary>
    public class TargetPositionCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of TargetPositionCodec
        /// </summary>
        public static TargetPositionCodec Instance { get; } = new TargetPositionCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "localHitPoint",
            "orientation",
            "position",
            "target",
            "turretAngle",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
            StringCodec.Instance,
            FloatCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of TargetPositionCodec
        /// </summary>
        private TargetPositionCodec() : base()
        {
        }
    }
}
