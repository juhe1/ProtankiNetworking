namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sent when a mine is placed or removed.
/// </summary>
public class MineLocation : Packet
{
	[Encode(0)]
	public string? MineId { get; set; }

	[Encode(1)]
	public float X { get; set; }

	[Encode(2)]
	public float Y { get; set; }

	[Encode(3)]
	public float Z { get; set; }

	[Encode(4)]
	public string? UserId { get; set; }

	public const int ID_CONST = 272183855;
	public override int Id => ID_CONST;
	public override string Description => "Sent when a mine is placed or removed.";
}
