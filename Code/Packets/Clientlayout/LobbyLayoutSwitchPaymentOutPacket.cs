using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Clientlayout;

public class LobbyLayoutSwitchPaymentOutPacket : Packet
{

	public const int ID_CONST = 1153801756;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
