using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BattleInfoData : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? MapName { get; set; }

	[Encode(2)]
	public BattleMode? Mode { get; set; }

	[Encode(3)]
	public bool PrivateBattle { get; set; }

	[Encode(4)]
	public bool ProBattle { get; set; }

	[Encode(5)]
	public Range? Range { get; set; }

	[Encode(6)]
	public int ServerNumber { get; set; }

}
