namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Current Supply Effect
/// </summary>
public class LoadSupplyEffect : Packet
{
	[Encode(0)]
	public string? Json { get; set; }

	public const int ID_CONST = 417965410;
	public override int Id => ID_CONST;
	public override string Description => "Load Current Supply Effect";
}
