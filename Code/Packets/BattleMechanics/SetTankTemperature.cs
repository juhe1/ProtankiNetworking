namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for setting a tank's temperature (tankId, temperature).
/// </summary>
public class SetTankTemperature : Packet
{
	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public float Temperature { get; set; }

	public const int ID_CONST = 581377054;
	public override int Id => ID_CONST;
	public override string Description => "Set tank temperature (tankId, temperature)";
}
