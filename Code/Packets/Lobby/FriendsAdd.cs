namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for adding a friend (userId).
/// </summary>
public class FriendsAdd : Packet
{
	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1457773660;
	public override int Id => ID_CONST;
	public override string Description => "Friends add (userId)";
}
