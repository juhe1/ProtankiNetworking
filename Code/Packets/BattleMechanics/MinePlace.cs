namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sent when a mine is placed.
/// </summary>
public class MinePlace : Packet
{
	[Encode(0)]
	public string? MineId { get; set; }

	public const int ID_CONST = -624217047;
	public override int Id => ID_CONST;
	public override string Description => "Sent when a mine is placed.";
}
