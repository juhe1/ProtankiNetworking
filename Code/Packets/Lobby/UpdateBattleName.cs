namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
/// Sent by server when battle name is changed.
/// </summary>
public class UpdateBattleName : Packet
{
	[Encode(0)]
	public String? BattleId { get; set; }
	public String? NewName { get; set; }

	public const int ID_CONST = 2011860838;
	public override int Id => ID_CONST;
	public override string Description => "Sent by server when battle name is changed.";
}
