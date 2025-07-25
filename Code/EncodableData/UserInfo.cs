using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class UserInfo : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public ChatModeratorLevel? ChatModeratorLevel { get; set; }

	[Encode(1)]
	public int Deaths { get; set; }

	[Encode(2)]
	public int Kills { get; set; }

	[Encode(3)]
	public byte Rank { get; set; }

	[Encode(4)]
	public int Score { get; set; }

	[Encode(5)]
	public string? Uid { get; set; }
}
