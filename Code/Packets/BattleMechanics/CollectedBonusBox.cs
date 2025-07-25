namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     A bonus box was picked up
/// </summary>
public class CollectedBonusBox : Packet
{
	[Encode(0)]
	public string? BonusId { get; set; }

	public const int ID_CONST = -1291499147;
	public override int Id => ID_CONST;
	public override string Description => "A bonus box was picked up";
}
