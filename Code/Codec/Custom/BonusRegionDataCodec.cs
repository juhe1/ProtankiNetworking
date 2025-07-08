using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Codec.Custom
{
    /// <summary>
    /// Codec for BonusRegionData (position, rotation, regionType).
    /// </summary>
    public class BonusRegionDataCodec : CustomBaseCodec
    {
        public static BonusRegionDataCodec Instance { get; } = new BonusRegionDataCodec();

        protected override string[] Attributes => new[]
        {
            "position",
            "rotation",
            "regionType"
        };

        protected override ICodec[] CodecObjects => new ICodec[]
        {
            Vector3DCodec.Instance, // position
            Vector3DCodec.Instance, // rotation
            BonusesTypeCodec.Instance, // regionType
        };
    }
} 