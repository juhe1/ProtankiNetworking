using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Inventory;

public class InventoryItemActivatedInPacket : Packet
{

	[Encode(0)]
	public string? ItemId { get; set; }

	[Encode(1)]
	public int ClientTime { get; set; }

	[Encode(2)]
	public bool Decrease { get; set; }

	public const int ID_CONST = 2032104949;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
