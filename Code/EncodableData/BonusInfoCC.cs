using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class BonusInfoCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public string? BottomText { get; set; }

	[Encode(1)]
	public Resource? Image { get; set; }

	[Encode(2)]
	public string? TopText { get; set; }

}
