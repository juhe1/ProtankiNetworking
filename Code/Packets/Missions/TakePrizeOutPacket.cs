using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class TakePrizeOutPacket : Packet
{

	[Encode(0)]
	public int MissionId { get; set; }

	public const int ID_CONST = -867767128;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
