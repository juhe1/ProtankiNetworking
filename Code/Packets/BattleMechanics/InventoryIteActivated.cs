namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for activated inventory item (itemId, time, decrease).
/// </summary>
public class InventoryIteActivated : Packet
{
	[Encode(0)]
	public string? ItemId { get; set; }

	[Encode(1)]
	public int Time { get; set; }

	[Encode(2)]
	public bool Decrease { get; set; }

	public const int ID_CONST = 2032104949;
	public override int Id => ID_CONST;
	public override string Description => "Inventory item activated (itemId, time, decrease)";
}
