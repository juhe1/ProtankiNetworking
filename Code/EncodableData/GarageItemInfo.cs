using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class GarageItemInfo : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public ItemCategoryEnum? Category { get; set; }

	[Encode(1)]
	public ItemViewCategoryEnum? ItemViewCategory { get; set; }

	[Encode(2)]
	public int ModificationIndex { get; set; }

	[Encode(3)]
	public bool Mounted { get; set; }

	[Encode(4)]
	public string? Name { get; set; }

	[Encode(5)]
	public int Position { get; set; }

	[Encode(6)]
	public bool PremiumItem { get; set; }

	[Encode(7)]
	public Resource? Preview { get; set; }

	[Encode(8)]
	public int RemainingTimeInMS { get; set; }

}
