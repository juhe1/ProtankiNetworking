using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for hitting a target: time, shotId, target, targetPosition, hitPointWorld. Used in Twins and Ricochet.
/// </summary>
public class TwinsHitTargetOut : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public int ShotId { get; set; }

	[Encode(2)]
	public string? Target { get; set; }

	[Encode(3)]
	public Vector3D? TargetPosition { get; set; }

	[Encode(4)]
	public Vector3D? HitPointWorld { get; set; }

	public const int ID_CONST = -1723353904;
	public override int Id => ID_CONST;

	public override string Description =>
		"Hit target command (time, shotId, target, targetPosition, hitPointWorld). Used in Twin and Ricochets.";
}
