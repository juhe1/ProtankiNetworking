namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Change crystal count.
/// </summary>
public class ChangeCrystalCount : Packet
{
	[Encode(0)]
	public int CrystalCount { get; set; }

	public const int ID_CONST = -593513288;
	public override int Id => ID_CONST;
	public override string Description => "Change crystal count.";
}
