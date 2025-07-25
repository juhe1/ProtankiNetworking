

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Change location in shop
/// </summary>
public class BuyFromShop : Packet
{
    [Encode(0)]
    public string? ItemId { get; set; }

    [Encode(1)]
    public string? ItemType { get; set; }

    public const int ID_CONST = 880756819;
    public override int Id => ID_CONST;
    public override string Description => "Change location in shop";


}