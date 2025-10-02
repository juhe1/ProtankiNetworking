namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
/// Tank model is unloaded.
/// </summary>
public class DespawnAlive : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = 1719707347;
	public override int Id => ID_CONST;
	public override string Description => "Tank model is unloaded.";
}
