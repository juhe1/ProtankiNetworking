using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class SelectFirstDepotItemInPacket : Packet
{

	public const int ID_CONST = -1763914667;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
