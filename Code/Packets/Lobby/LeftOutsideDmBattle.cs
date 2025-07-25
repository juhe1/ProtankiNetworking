namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     A player has left a DM battle, the observer being outside the battle
/// </summary>
public class LeftOutsideDmBattle : Packet
{
	[Encode(0)]
	public string? BattleID { get; set; }

	[Encode(1)]
	public string? Username { get; set; }

	public const int ID_CONST = 504016996;
	public override int Id => ID_CONST;
	public override string Description =>
		"A player has left a DM battle, the observer being outside the battle";
}
