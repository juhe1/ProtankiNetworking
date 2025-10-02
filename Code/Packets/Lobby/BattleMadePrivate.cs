namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
/// Sent by server when battle is made private.
/// </summary>
public class BattleMadePrivate : Packet
{
	[Encode(0)]
	public String? BattleId { get; set; }

	public const int ID_CONST = 1149131596;
	public override int Id => ID_CONST;
	public override string Description => "Sent by server when battle is made private.";
}
