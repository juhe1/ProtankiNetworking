using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class FitItemOutPacket : Packet
{

	[Encode(0)]
	public string? ItemId { get; set; }

	public const int ID_CONST = 1091756732;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
