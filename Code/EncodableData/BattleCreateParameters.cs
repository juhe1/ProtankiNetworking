using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BattleCreateParameters : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public bool AutoBalance { get; set; }

	[Encode(1)]
	public BattleMode? BattleMode { get; set; }

	[Encode(2)]
	public EquipmentConstraintsMode? EquipmentConstraintsMode { get; set; }

	[Encode(3)]
	public bool FriendlyFire { get; set; }

	[Encode(4)]
	public BattleLimits? Limits { get; set; }

	[Encode(5)]
	public string? MapId { get; set; }

	[Encode(6)]
	public int MaxPeopleCount { get; set; }

	[Encode(7)]
	public string? Name { get; set; }

	[Encode(8)]
	public bool ParkourMode { get; set; }

	[Encode(9)]
	public bool PrivateBattle { get; set; }

	[Encode(10)]
	public bool ProBattle { get; set; }

	[Encode(11)]
	public Range? RankRange { get; set; }

	[Encode(12)]
	public bool ReArmorEnabled { get; set; }

	[Encode(13)]
	public MapTheme? Theme { get; set; }

	[Encode(14)]
	public bool WithoutBonuses { get; set; }

	[Encode(15)]
	public bool WithoutCrystals { get; set; }

	[Encode(16)]
	public bool WithoutSupplies { get; set; }

	[Encode(17)]
	public bool WithoutUpgrades { get; set; }

	[Encode(18)]
	public bool ReducedResistances { get; set; }

	[Encode(19)]
	public bool EsportDropTiming { get; set; }

	[Encode(20)]
	public bool WithoutGoldBoxes { get; set; }

	[Encode(21)]
	public bool WithoutGoldSiren { get; set; }

	[Encode(22)]
	public bool WithoutGoldZone { get; set; }

	[Encode(23)]
	public bool WithoutMedkit { get; set; }

	[Encode(24)]
	public bool WithoutMines { get; set; }

	[Encode(25)]
	public bool RandomGold { get; set; }

	[Encode(26)]
	public bool DependentCooldownEnabled { get; set; }
}
