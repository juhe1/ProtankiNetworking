namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Buy from shop
/// </summary>
public class ChangeLocation : Packet
{
	[Encode(0)]
	public string? Location_abbreviation { get; set; }

	public const int ID_CONST = 921004371;
	public override int Id => ID_CONST;
	public override string Description => "Buy from shop";
}
