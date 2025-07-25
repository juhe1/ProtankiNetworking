namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Supply box bonus id
/// </summary>
public class RemoveBonusBox : Packet
{
	[Encode(0)]
	public string? BonusId { get; set; }

	public const int ID_CONST = -2026749922;
	public override int Id => ID_CONST;
	public override string Description => "Supply box bonus id";
}
