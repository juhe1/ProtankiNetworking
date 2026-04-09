using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Smoky;

public class SmokyShootTargetInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public Vector3D? HitPoint { get; set; }

	[Encode(3)]
	public float WeakeningCoeff { get; set; }

	[Encode(4)]
	public bool IsCritical { get; set; }

	public const int ID_CONST = -1334002026;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
