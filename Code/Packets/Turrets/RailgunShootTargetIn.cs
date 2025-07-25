using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Railgun shoot target event.
/// </summary>
public class RailgunShootTargetIn : Packet
{
	[Encode(0)]
	public string? ShooterUserId { get; set; }

	[Encode(1)]
	public Vector3D? StaticHitPoint { get; set; }

	[Encode(2)]
	public string?[]? TargetUserIds { get; set; }

	[Encode(3)]
	public Vector3D?[]? TargetHitPoints { get; set; }

	public const int ID_CONST = -369590613;
	public override int Id => ID_CONST;
	public override string Description => "Send Railgun shoot target event";
}
