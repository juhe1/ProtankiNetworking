namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Battle time left in seconds
/// </summary>
public class BattleTimeLeft : Packet
{
	[Encode(0)]
	public int TimeLimitInSec { get; set; }

	public const int ID_CONST = 732434644;
	public override int Id => ID_CONST;
	public override string Description => "Battle time left in seconds";
}
