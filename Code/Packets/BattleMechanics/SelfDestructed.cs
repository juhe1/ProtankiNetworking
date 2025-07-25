namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Information about a self destructed tank
/// </summary>
public class SelfDestructed : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public int RespDelay { get; set; }

	public const int ID_CONST = 162656882;
	public override int Id => ID_CONST;
	public override string Description => "Information about a self destructed tank";
}
