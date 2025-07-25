namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Shot effect packet
/// </summary>
public class ShotEffect : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public int EffectId { get; set; }

	public const int ID_CONST = -1994318624;
	public override int Id => ID_CONST;
	public override string Description => "Shot effect packet";
}
