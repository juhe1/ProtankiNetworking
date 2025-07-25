namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Do we need an invite code to access the server?
/// </summary>
public class InviteCodeStatus : Packet
{
	[Encode(0)]
	public bool InviteEnabled { get; set; }

	public const int ID_CONST = 444933603;
	public override int Id => ID_CONST;
	public override string Description => "Do we need an invite code to access the server?";
}
