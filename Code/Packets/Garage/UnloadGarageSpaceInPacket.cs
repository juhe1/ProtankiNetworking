using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class UnloadGarageSpaceInPacket : Packet
{

	public const int ID_CONST = 1211186637;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
