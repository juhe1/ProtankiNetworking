using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading bonus regions configuration (BonusRegionsCC).
/// </summary>
public class LoadBonusRegionsCC : AbstractPacket
{
    public const int ID_CONST = -959048700;
    public override int Id => ID_CONST;
    public override string Description => "Load bonus regions configuration (BonusRegionsCC)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(BonusRegionResourceCodec.Instance, false), // bonusRegionResources
        new VectorCodec(BonusRegionDataCodec.Instance, false) // bonusRegions
    };

    public override string[] Attributes => new[]
    {
        "bonusRegionResources",
        "bonusRegions"
    };
}