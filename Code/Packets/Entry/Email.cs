namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     email
/// </summary>
public class Email : Packet
{
	[Encode(0)]
	public string? EmailAddress { get; set; }

	[Encode(1)]
	public bool EmailConfirmed { get; set; }

	public const int ID_CONST = 613462801;
	public override int Id => ID_CONST;
	public override string Description => "email";
}
