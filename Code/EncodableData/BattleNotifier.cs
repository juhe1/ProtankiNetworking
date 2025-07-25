using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BattleNotifier : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public BattleInfo? BattleInfo { get; set; }

	[Encode(1)]
	public string? Username { get; set; }
}
