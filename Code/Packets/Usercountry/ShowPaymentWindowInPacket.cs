using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usercountry;

public class ShowPaymentWindowInPacket : Packet
{

	public const int ID_CONST = 1870342869;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
