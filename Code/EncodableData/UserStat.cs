using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class UserStat : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public short Deaths { get; set; }

	[Encode(1)]
	public short Kills { get; set; }

	[Encode(2)]
	public int Score { get; set; }

	[Encode(3)]
	public string? User { get; set; }

}
