using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Clientlayout;

public class SwitchGarageOutPacket : Packet
{

	public const int ID_CONST = -479046431;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
