namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player despawns while alive
/// </summary>
public class DespawnAlive : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = 1719707347;
	public override int Id => ID_CONST;
	public override string Description => "Player despawns while alive";
}
