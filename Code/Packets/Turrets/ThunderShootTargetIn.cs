using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder shooting at a target, with relative hit point.
/// </summary>
public class ThunderShootTargetIn : Packet
{
	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public Vector3D? RelativeHitPoint { get; set; }

	public const int ID_CONST = -190359403;
	public override int Id => ID_CONST;
	public override string Description => "Thunder shoot at target with relative hit point";
}
