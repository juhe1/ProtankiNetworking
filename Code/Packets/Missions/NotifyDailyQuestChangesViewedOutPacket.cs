using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class NotifyDailyQuestChangesViewedOutPacket : Packet
{

	public const int ID_CONST = 1417347634;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
