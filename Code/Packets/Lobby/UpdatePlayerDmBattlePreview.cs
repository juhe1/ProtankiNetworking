namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Updates a player's kills in a DM battle preview
/// </summary>
public class UpdatePlayerDmBattlePreview : Packet
{
	[Encode(0)]
	public string? BattleID { get; set; }

	[Encode(1)]
	public string? Username { get; set; }

	[Encode(2)]
	public int Kills { get; set; }

	public const int ID_CONST = -1263036614;
	public override int Id => ID_CONST;
	public override string Description => "Updates a player's kills in a DM battle preview";
}
