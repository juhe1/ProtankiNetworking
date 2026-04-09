using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Railgun;

public class RailgunShootTargetInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public Vector3D? StaticHitPoint { get; set; }

	[Encode(2)]
	public string?[]? Targets { get; set; }

	[Encode(3)]
	public Vector3D?[]? TargetHitPoints { get; set; }

	public const int ID_CONST = -369590613;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
