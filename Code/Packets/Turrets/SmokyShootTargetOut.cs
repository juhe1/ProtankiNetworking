using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Our smoky shot hit a target
/// </summary>
public class SmokyShootTargetOut : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public short IncarnationID { get; set; }

	[Encode(3)]
	public Vector3D? TargetBodyPosition { get; set; }

	[Encode(4)]
	public Vector3D? LocalHitPoint { get; set; }

	[Encode(5)]
	public Vector3D? GlobalHitPoint { get; set; }

	public const int ID_CONST = 229267683;
	public override int Id => ID_CONST;
	public override string Description => "Our smoky shot hit a target";
}
