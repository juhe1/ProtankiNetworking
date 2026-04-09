using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class UserCountryCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public CountryInfo?[]? Countries { get; set; }

	[Encode(1)]
	public string? DefaultCountryCode { get; set; }

	[Encode(2)]
	public bool LocationCheckEnabled { get; set; }

}
