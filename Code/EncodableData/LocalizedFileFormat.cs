using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class LocalizedFileFormat : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public ImagePair?[]? Images { get; set; }

	[Encode(1)]
	public string?[]? Strings { get; set; }

}
