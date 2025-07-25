namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Open Friends List
/// </summary>
public class OpenFriendsList : Packet
{
	public const int ID_CONST = 1441234714;
	public override int Id => ID_CONST;
	public override string Description => "Open Friends List";
}
