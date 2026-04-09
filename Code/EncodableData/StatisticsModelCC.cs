using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class StatisticsModelCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public BattleMode? BattleMode { get; set; }

	[Encode(1)]
	public EquipmentConstraintsMode? EquipmentConstraintsMode { get; set; }

	[Encode(2)]
	public int Fund { get; set; }

	[Encode(3)]
	public BattleLimits? Limits { get; set; }

	[Encode(4)]
	public string? BattleName { get; set; }

	[Encode(5)]
	public int MaxPeopleCount { get; set; }

	[Encode(6)]
	public bool ParkourMode { get; set; }

	[Encode(7)]
	public int PremiumBonusInPercent { get; set; }

	[Encode(8)]
	public bool Spectator { get; set; }

	[Encode(9)]
	public string?[]? SuspiciousUserIds { get; set; }

	[Encode(10)]
	public int TimeLeft { get; set; }

}
