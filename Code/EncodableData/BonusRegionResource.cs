using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BonusRegionResource : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Resource? DropZoneResource { get; set; }

	[Encode(1)]
	public BonusType? RegionType { get; set; }

}
