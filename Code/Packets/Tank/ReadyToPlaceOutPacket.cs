using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class ReadyToPlaceOutPacket : Packet
{

	public const int ID_CONST = -1378839846;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
