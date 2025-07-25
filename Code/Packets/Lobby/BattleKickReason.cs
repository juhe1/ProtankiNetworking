namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Reason why player was kicked from battle
/// </summary>
public class BattleKickReason : Packet
{
	[Encode(0)]
	public string? Reason { get; set; }

	public const int ID_CONST = -322235316;
	public override int Id => ID_CONST;
	public override string Description => "Reason why player was kicked from battle";
}
