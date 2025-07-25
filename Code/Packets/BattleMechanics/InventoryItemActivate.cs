namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for activating an inventory item (itemId).
/// </summary>
public class InventoryItemActivate : Packet
{
	[Encode(0)]
	public string? ItemId { get; set; }

	public const int ID_CONST = -2102525054;
	public override int Id => ID_CONST;
	public override string Description => "Inventory item activate (itemId)";
}
