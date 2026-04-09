using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usercountry;

public class LoadUserCountryModelInPacket : Packet
{

	[Encode(0)]
	public UserCountryCC? Cc { get; set; }

	public const int ID_CONST = -1232334539;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
