using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for stream weapon hit (time, targets, incarnations, positions, hitPoints). Freeze and Flamethrower uses
///     this.
/// </summary>
public class StreamWeaponHit : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public string?[]? Targets { get; set; }

	[Encode(2)]
	public short[]? Incarnations { get; set; }

	[Encode(3)]
	public Vector3D?[]? Positions { get; set; }

	[Encode(4)]
	public Vector3D?[]? HitPoints { get; set; }

	public const int ID_CONST = -2123941185;

	public override string Description =>
		"Stream weapon hit (time, targets, incarnations, positions, hitPoints). Freeze and Flamethrower uses this.";
}
