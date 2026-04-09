using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class WeeklyQuestDescription : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int CurrentQuestLevel { get; set; }

	[Encode(1)]
	public int CurrentQuestStreak { get; set; }

	[Encode(2)]
	public bool DoneForToday { get; set; }

	[Encode(3)]
	public Resource? QuestImage { get; set; }

	[Encode(4)]
	public Resource? RewardImage { get; set; }

}
