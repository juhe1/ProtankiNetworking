using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for hit static command out (time, shotId, hitPointWorld).
/// </summary>
public class HitStaticCommandOut : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public int ShotId { get; set; }

	[Encode(2)]
	public Vector3D? HitPointWorld { get; set; }

	public const int ID_CONST = -482023661;
	public override int Id => ID_CONST;
	public override string Description => "Hit static command out (time, shotId, hitPointWorld)";
}
