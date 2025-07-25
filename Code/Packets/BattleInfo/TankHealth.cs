namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Updates the health of a tank
/// </summary>
public class TankHealth : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public float Health { get; set; }

	public const int ID_CONST = -611961116;
	public override int Id => ID_CONST;
	public override string Description => "Updates the health of a tank";
}
