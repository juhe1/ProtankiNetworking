using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usercountry;

public class RequestUserCountryInPacket : Packet
{

	[Encode(0)]
	public string? Country { get; set; }

	public const int ID_CONST = 1961542160;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
