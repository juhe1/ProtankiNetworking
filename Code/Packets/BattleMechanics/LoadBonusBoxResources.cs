namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Bonus Box Resources
/// </summary>
public class LoadBonusBoxResources : Packet
{
	[Encode(0)]
	public string? Json { get; set; }

	public const int ID_CONST = 228171466;
	public override int Id => ID_CONST;
	public override string Description => "Load Bonus Box Resources";
}
