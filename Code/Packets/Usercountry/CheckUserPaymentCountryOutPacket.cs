using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usercountry;

public class CheckUserPaymentCountryOutPacket : Packet
{

	public const int ID_CONST = -296048697;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
