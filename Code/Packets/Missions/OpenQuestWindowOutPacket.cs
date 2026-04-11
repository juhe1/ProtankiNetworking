using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Missions;

public class OpenQuestWindowOutPacket : Packet
{

	public const int ID_CONST = 1227293080;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
