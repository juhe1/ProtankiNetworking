namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Turret Control Packet
/// </summary>
public class TurretControl : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public short SpecificationID { get; set; }

	[Encode(2)]
	public byte Control { get; set; }

	public const int ID_CONST = -1749108178;
	public override int Id => ID_CONST;
	public override string Description => "Turret Control Packet";
}
