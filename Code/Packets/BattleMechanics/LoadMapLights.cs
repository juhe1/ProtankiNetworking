namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Map Lights
/// </summary>
public class LoadMapLights : Packet
{
	[Encode(0)]
	public string? Json { get; set; }

	public const int ID_CONST = -152638117;
	public override int Id => ID_CONST;
	public override string Description => "Load Map Lights";
}
