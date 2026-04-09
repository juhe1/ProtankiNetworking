using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Railgun;

public class RailgunStartChargingOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -1759063234;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
