using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class BuyMultipleItemsOutPacket : Packet
{

	[Encode(0)]
	public string? ItemId { get; set; }

	[Encode(1)]
	public int Count { get; set; }

	[Encode(2)]
	public int Cost { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
