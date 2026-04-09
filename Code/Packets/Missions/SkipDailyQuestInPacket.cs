using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class SkipDailyQuestInPacket : Packet
{

	[Encode(0)]
	public int MissionId { get; set; }

	[Encode(1)]
	public DailyQuestInfo? Mission { get; set; }

	public const int ID_CONST = -1266665816;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
