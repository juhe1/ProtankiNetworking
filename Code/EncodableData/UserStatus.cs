using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class UserStatus : IEncodable
{
	public bool IsOptional { get; } = true;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int ModLevel { get; set; }

	[Encode(1)]
	public string? Ip { get; set; }

	[Encode(2)]
	public int Rank { get; set; }

	[Encode(3)]
	public string? Username { get; set; }
}
