namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Get shop info
/// </summary>
public class ShopInfo : Packet
{
	[Encode(0)]
	public int Data { get; set; }

	public const int ID_CONST = 1863710730;
	public override int Id => ID_CONST;
	public override string Description => "Get shop info";
}
