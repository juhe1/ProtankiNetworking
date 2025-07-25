namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Sent when a player joins a global DM battle, outside from the observer's perspective.
/// </summary>
public class JoinedOutsideDmBattle : Packet
{
	[Encode(0)]
	public string? BattleID { get; set; }

	[Encode(1)]
	public string? Username { get; set; }

	public const int ID_CONST = -2133657895;

	public override string Description =>
		"Sent when a player joins a global DM battle, outside from the observer's perspective.";
}
