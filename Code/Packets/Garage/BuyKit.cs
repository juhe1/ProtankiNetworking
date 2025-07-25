namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Buy a kit
/// </summary>
public class BuyKit : Packet
{
	[Encode(0)]
	public string? Item_id { get; set; }

	[Encode(1)]
	public int Base_cost { get; set; }

	public const int ID_CONST = -523392052;
	public override int Id => ID_CONST;
	public override string Description => "Buy a kit";
}
