using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BonusRegionsCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public BonusRegionResource?[]? BonusRegionResources { get; set; }

	[Encode(1)]
	public BonusRegionData?[]? BonusRegions { get; set; }

}
