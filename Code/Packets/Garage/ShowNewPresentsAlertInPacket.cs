using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class ShowNewPresentsAlertInPacket : Packet
{

	public const int ID_CONST = -1638767166;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
