using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft shooting at targets, with static hit point, target list, and impact force.
/// </summary>
public class ShaftShootTargetIn : Packet
{
	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public Vector3D? StaticHitPoint { get; set; }

	[Encode(2)]
	public string?[]? Targets { get; set; }

	[Encode(3)]
	public Vector3D?[]? TargetHitPoints { get; set; }

	[Encode(4)]
	public float ImpactForce { get; set; }

	public const int ID_CONST = 1184835319;

	public override string Description =>
		"Shaft shoot at targets (shooter, staticHitPoint, targets, targetHitPoints, impactForce)";
}
