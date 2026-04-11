using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class UserStatus : IEncodable
{
	public bool IsOptional { get; } = true;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public ChatModeratorLevel? ChatModeratorLevel { get; set; }

	[Encode(1)]
	public string? Ip { get; set; }

	[Encode(2)]
	public int RankIndex { get; set; }

	[Encode(3)]
	public string? UserId { get; set; }
}
