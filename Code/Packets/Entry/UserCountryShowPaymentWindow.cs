

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Packet for showing the user payment window (no attributes).
/// </summary>
public class UserCountryShowPaymentWindow : Packet
{
    public const int ID_CONST = 1870342869;
    public override int Id => ID_CONST;
    public override string Description => "User country show payment window (no attributes)";
} 