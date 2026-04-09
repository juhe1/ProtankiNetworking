using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Inventory;

public class InventoryItemActivateOutPacket : Packet
{

	[Encode(0)]
	public string? ItemId { get; set; }

	public const int ID_CONST = -2102525054;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
