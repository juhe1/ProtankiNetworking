

namespace ProtankiNetworking.Packets.Shop;

/// <summary>
///     Promocode applied successfully
/// </summary>
public class PromocodeSuccess : Packet
{
    public const int ID_CONST = -1859441081;
    public override int Id => ID_CONST;
    public override string Description => "Promocode applied successfully";


}