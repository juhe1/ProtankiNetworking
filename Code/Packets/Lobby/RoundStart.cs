namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Starts a new round in the existing battle
/// </summary>
public class RoundStart : Packet
{
	[Encode(0)]
	public string? BattleID { get; set; }

	public const int ID_CONST = -344514517;
	public override int Id => ID_CONST;
	public override string Description => "Starts a new round in the existing battle";
}
