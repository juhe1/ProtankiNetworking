using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class ShowQuestWindowInPacket : Packet
{

	[Encode(0)]
	public DailyQuestInfo?[]? Missions { get; set; }

	[Encode(1)]
	public WeeklyQuestDescription? WeeklyStreakInfo { get; set; }

	public const int ID_CONST = 809822533;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
