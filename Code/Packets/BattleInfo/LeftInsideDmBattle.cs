namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A player has left a DM battle, the observer being within the battle
/// </summary>
public class LeftInsideDmBattle : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = -1689876764;
	public override int Id => ID_CONST;
	public override string Description =>
		"A player has left a DM battle, the observer being within the battle";
}
