using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BattleUserStats : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int Deaths { get; set; }

	[Encode(1)]
	public int Kills { get; set; }

	[Encode(2)]
	public int Score { get; set; }

	[Encode(3)]
	public string? User { get; set; }
}
