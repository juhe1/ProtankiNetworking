using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class BattleInviteMessage : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public bool AvailableRank { get; set; }

	[Encode(1)]
	public bool AvailableSlot { get; set; }

	[Encode(2)]
	public string? BattleId { get; set; }

	[Encode(3)]
	public string? MapName { get; set; }

	[Encode(4)]
	public BattleMode? Mode { get; set; }

	[Encode(5)]
	public bool NoSuppliesBattle { get; set; }

	[Encode(6)]
	public bool PrivateBattle { get; set; }

}
