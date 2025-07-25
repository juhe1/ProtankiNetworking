namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Collect a crystal box
/// </summary>
public class CollectCryBox : Packet
{
	[Encode(0)]
	public string? BonusId { get; set; }

	public const int ID_CONST = -1047185003;
	public override int Id => ID_CONST;
	public override string Description => "Collect a crystal box";
}
