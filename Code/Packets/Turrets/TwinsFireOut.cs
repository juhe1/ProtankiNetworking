using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for firing a turret: time, barrel, shotId, shotDirection.
/// </summary>
public class TwinsFireOut : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public byte Barrel { get; set; }

	[Encode(2)]
	public int ShotId { get; set; }

	[Encode(3)]
	public Vector3D? ShotDirection { get; set; }

	public const int ID_CONST = -159686980;
	public override int Id => ID_CONST;
	public override string Description => "Fire command (time, barrel, shotId, shotDirection).";
}
