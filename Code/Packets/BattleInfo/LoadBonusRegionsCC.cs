using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet for loading bonus regions configuration (BonusRegionsCC).
    /// </summary>
    public class LoadBonusRegionsCC : AbstractPacket
    {
        public static int Id { get; } = -959048700;
        public override string Description => "Load bonus regions configuration (BonusRegionsCC)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(BonusRegionResourceCodec.Instance, false), // bonusRegionResources
            new VectorCodec(BonusRegionDataCodec.Instance, false), // bonusRegions
        };
        public override string[] Attributes => new string[]
        {
            "bonusRegionResources",
            "bonusRegions",
        };
    }
} 