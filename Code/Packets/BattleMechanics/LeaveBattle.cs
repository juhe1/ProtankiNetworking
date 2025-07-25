namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Leaves battle to a layout (0 = Lobby, 1 = Garage)
/// </summary>
public class LeaveBattle : Packet
{
	[Encode(0)]
	public int Layout { get; set; }

	public const int ID_CONST = 377959142;
	public override int Id => ID_CONST;
	public override string Description => "Leaves battle to a layout (0 = Lobby, 1 = Garage)";
}
