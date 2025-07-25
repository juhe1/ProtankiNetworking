namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Purchasable Items
/// </summary>
public class LoadPurchasableItems : Packet
{
	[Encode(0)]
	public string? Json { get; set; }

	public const int ID_CONST = -300370823;
	public override int Id => ID_CONST;
	public override string Description => "Load Purchasable Items";
}
