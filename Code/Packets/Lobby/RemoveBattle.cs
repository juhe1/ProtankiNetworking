namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Removes a battle from the lobby
/// </summary>
public class RemoveBattle : Packet
{
	[Encode(0)]
	public string? BattleID { get; set; }

	public const int ID_CONST = -1848001147;
	public override int Id => ID_CONST;
	public override string Description => "Removes a battle from the lobby";
}
