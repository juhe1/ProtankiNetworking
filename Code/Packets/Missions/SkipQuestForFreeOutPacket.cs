using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class SkipQuestForFreeOutPacket : Packet
{

	[Encode(0)]
	public int MissionId { get; set; }

	public const int ID_CONST = 326032325;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
