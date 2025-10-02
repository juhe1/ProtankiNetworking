using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Sent when a player joins a global Team battle, outside from the observer's perspective.
/// </summary>
public class JoinedOutsideTeamBattle : Packet
{
	[Encode(0)]
	public string? BattleID { get; set; }

	[Encode(1)]
	public string? Username { get; set; }

	[Encode(2)]
	public BattleTeam Team { get; set; }

	public const int ID_CONST = -169305322;
	public override int Id => ID_CONST;

	public override string Description =>
		"Sent when a player joins a global Team battle, outside from the observer's perspective.";
}
