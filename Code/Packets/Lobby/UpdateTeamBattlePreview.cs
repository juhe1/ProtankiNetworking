using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Updates a team's score in the battle preview
/// </summary>
public class UpdateSelectedTeamBattleScore : Packet
{
	[Encode(0)]
	public string? BattleID { get; set; }

	[Encode(1)]
	public BattleTeam Team { get; set; }

	[Encode(2)]
	public int Score { get; set; }

	public const int ID_CONST = 1428217189;
	public override int Id => ID_CONST;
	public override string Description => "Updates a team's score in the battle preview";
}
