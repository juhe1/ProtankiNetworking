using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class ActivateTankOutPacket : Packet
{

	public const int ID_CONST = 1178028365;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
