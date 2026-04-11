using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class TargetPosition : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Vector3D? LocalHitPoint { get; set; }

	[Encode(1)]
	public Vector3D? Orientation { get; set; }

	[Encode(2)]
	public Vector3D? Position { get; set; }

	[Encode(3)]
	public float TurretAngle { get; set; }

}
