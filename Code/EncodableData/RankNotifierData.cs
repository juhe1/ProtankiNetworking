using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class RankNotifierData : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public byte Rank { get; set; }

	[Encode(1)]
	public string? UserId { get; set; }

}
