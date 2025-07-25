namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Bonus Box Resources
/// </summary>
public class UserSuppliesInfo : Packet
{
	[Encode(0)]
	public string? Json { get; set; }

	public const int ID_CONST = -137249251;
	public override int Id => ID_CONST;
	public override string Description => "Load Bonus Box Resources";
}
