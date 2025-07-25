namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for revoking a friend (userId).
/// </summary>
public class FriendsRevoke : Packet
{
	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = 84050355;
	public override int Id => ID_CONST;
	public override string Description => "Friends revoke (userId)";
}
