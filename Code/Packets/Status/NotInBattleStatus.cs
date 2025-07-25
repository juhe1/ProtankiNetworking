namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Sets the player's battle status to not in battle
/// </summary>
public class NotInBattleStatus : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = 1941694508;
	public override int Id => ID_CONST;
	public override string Description => "Sets the player's battle status to not in battle";
}
