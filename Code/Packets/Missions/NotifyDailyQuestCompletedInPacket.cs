using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class NotifyDailyQuestCompletedInPacket : Packet
{

	public const int ID_CONST = 1579425801;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
