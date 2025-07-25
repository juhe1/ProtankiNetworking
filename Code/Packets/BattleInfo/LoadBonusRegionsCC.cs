using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading bonus regions configuration (BonusRegionsCC).
/// </summary>
public class LoadBonusRegionsCC : Packet
{
	[Encode(0)]
	public BonusRegionResource?[]? BonusRegionResources { get; set; }

	[Encode(1)]
	public BonusRegionData?[]? BonusRegions { get; set; }

	public const int ID_CONST = -959048700;
	public override int Id => ID_CONST;
	public override string Description => "Load bonus regions configuration (BonusRegionsCC)";
}
