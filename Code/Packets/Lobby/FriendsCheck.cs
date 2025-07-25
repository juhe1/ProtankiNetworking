namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for checking a friend (userId).
/// </summary>
public class FriendsCheck : Packet
{
	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = 126880779;
	public override int Id => ID_CONST;
	public override string Description => "Friends check (userId)";
}
