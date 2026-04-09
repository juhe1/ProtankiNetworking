using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class ShowQuestWindowWithoutDailyQuestsInPacket : Packet
{

	[Encode(0)]
	public WeeklyQuestDescription? WeeklyStreakInfo { get; set; }

	public const int ID_CONST = 885055495;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
