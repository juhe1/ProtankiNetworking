namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft turret stopping manual targeting (shooter only).
/// </summary>
public class ShaftStopManualTargetingIn : Packet
{
	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = -1380283560;
	public override int Id => ID_CONST;
	public override string Description => "Shaft stop manual targeting (shooter)";
}
