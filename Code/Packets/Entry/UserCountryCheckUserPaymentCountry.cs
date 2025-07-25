namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Packet for checking user payment country (no attributes).
/// </summary>
public class UserCountryCheckUserPaymentCountry : Packet
{
	public const int ID_CONST = -296048697;
	public override int Id => ID_CONST;
	public override string Description => "User country check user payment country (no attributes)";
}
