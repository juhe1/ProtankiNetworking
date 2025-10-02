namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load BattleMapCC
/// </summary>
public class LoadBattleMapCC : Packet
{
	[Encode(0)]
	public string? Json { get; set; }

	public const int ID_CONST = -152638117;
	public override int Id => ID_CONST;
	public override string Description => "Load Map Lights";
}
