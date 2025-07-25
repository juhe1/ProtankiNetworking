

namespace ProtankiNetworking.Packets.Shop;

/// <summary>
///     Incorrect or expired promocode
/// </summary>
public class PromocodeFailed : Packet
{
    public const int ID_CONST = -1850050333;
    public override int Id => ID_CONST;
    public override string Description => "Incorrect or expired promocode";


}