using System;
using ProtankiNetworking.Utils;

using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for tankdamage
    /// </summary>
    public class TankDamageCodec : CustomBaseCodec
    {
        /// <summary>
        /// Gets the singleton instance of TankDamageCodec
        /// </summary>
        public static TankDamageCodec Instance { get; } = new TankDamageCodec();

        /// <summary>
        /// Gets the list of attribute names for this codec
        /// </summary>
        protected override string[] Attributes => new[]
        {
            "damage",
            "damageType",
            "target",
        };

        /// <summary>
        /// Gets the list of codec objects for this codec
        /// </summary>
        protected override ICodec[] CodecObjects => new ICodec[]
        {
            FloatCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
        };

        /// <summary>
        /// Creates a new instance of TankDamageCodec
        /// </summary>
        private TankDamageCodec() : base()
        {
        }
    }
}
