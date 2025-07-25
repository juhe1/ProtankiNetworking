namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     If the mount was successful or not
/// </summary>
public class CheckItemMounted : Packet
{
	[Encode(0)]
	public string? Item_id { get; set; }

	[Encode(1)]
	public bool Mounted { get; set; }

	public const int ID_CONST = 2062201643;
	public override int Id => ID_CONST;
	public override string Description => "If the mount was successful or not";
}
