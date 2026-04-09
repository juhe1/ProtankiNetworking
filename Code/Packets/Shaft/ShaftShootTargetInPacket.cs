using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftShootTargetInPacket : Packet
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
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
