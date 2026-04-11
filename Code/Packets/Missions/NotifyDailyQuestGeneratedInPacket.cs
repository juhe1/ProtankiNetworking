using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class NotifyDailyQuestGeneratedInPacket : Packet
{

	public const int ID_CONST = 956252237;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
