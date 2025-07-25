namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Packet for notifying that user email and password is set (no attributes).
/// </summary>
public class UserEmailAndPasswordNotifyPasswordIsSet : Packet
{
	public const int ID_CONST = 600420685;
	public override int Id => ID_CONST;
	public override string Description =>
		"User email and password notify password is set (no attributes)";
}
