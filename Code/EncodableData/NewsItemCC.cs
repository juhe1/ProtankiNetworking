using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class NewsItemCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public string? ImageUrl { get; set; }

	[Encode(1)]
	public string? NewsDate { get; set; }

	[Encode(2)]
	public string? NewsText { get; set; }

}
