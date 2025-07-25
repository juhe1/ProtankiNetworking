namespace ProtankiNetworking.Packets.Shop;

/// <summary>
///     Client uses a promocode
/// </summary>
public class SendPromocode : Packet
{
	[Encode(0)]
	public string? Promocode { get; set; }

	public const int ID_CONST = -511004908;
	public override int Id => ID_CONST;
	public override string Description => "Client uses a promocode";
}
