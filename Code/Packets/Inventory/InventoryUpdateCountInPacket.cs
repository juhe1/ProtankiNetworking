using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Inventory;

public class InventoryUpdateCountInPacket : Packet
{

	[Encode(0)]
	public string? ItemId { get; set; }

	[Encode(1)]
	public int Count { get; set; }

	public const int ID_CONST = -502907094;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
