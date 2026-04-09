using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class DailyQuestInfo : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public bool CanSkipForFree { get; set; }

	[Encode(1)]
	public string? Description { get; set; }

	[Encode(2)]
	public int FinishCriteria { get; set; }

	[Encode(3)]
	public Resource? Image { get; set; }

	[Encode(4)]
	public DailyQuestPrizeInfo?[]? Prizes { get; set; }

	[Encode(5)]
	public int Progress { get; set; }

	[Encode(6)]
	public int SkipCost { get; set; }

}
