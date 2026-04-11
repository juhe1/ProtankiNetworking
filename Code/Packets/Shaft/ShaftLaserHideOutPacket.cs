using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftLaserHideOutPacket : Packet
{

	public const int ID_CONST = 843751647;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
