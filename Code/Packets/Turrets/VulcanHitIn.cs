using ProtankiNetworking.EncodableData;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Vulcan hit information.
/// </summary>
public class VulcanHitIn : Packet
{
	[Encode(0)]
	public string? WeaponId { get; set; }

	[Encode(1)]
	public Vector3D? HitPosition { get; set; }

	[Encode(2)]
	public TargetHit?[]? Hits { get; set; }

	public const int ID_CONST = -891286317;
	public override int Id => ID_CONST;
	public override string Description => "Send Vulcan hit information";
}
