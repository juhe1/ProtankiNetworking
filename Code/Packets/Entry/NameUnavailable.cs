namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Said name is unavailable for registration with a list of alternative suggested usernames
/// </summary>
public class NameUnavailable : Packet
{
	[Encode(0)]
	public string?[]? Usernames { get; set; }

	public const int ID_CONST = 442888643;

	public override string Description =>
		"Said name is unavailable for registration with a list of alternative suggested usernames";
}
