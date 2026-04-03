using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
/// Some smoky user shot wall.
/// </summary>
public class SmokyShootWallIn : Packet
{
	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public Vector3D? HitPoint { get; set; }

	public const int ID_CONST = 546849203;
	public override int Id => ID_CONST;
	public override string Description => "Some smoky user shot wall.";
}
