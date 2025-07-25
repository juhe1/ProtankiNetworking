using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Ricochet hit target (time, target, shotId, targetPosition, impactPoints).
/// </summary>
public class RicochetHitTargetOut : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public int ShotId { get; set; }

	[Encode(3)]
	public Vector3D? TargetPosition { get; set; }

	[Encode(4)]
	public Vector3D?[]? ImpactPoints { get; set; }

	public const int ID_CONST = 1229701582;

	public override string Description =>
		"Ricochet hit target (time, target, shotId, targetPosition, impactPoints)";
}
