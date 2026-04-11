using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class MoveCommand : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Vector3D? AngularVelocity { get; set; }

	[Encode(1)]
	public byte Control { get; set; }

	[Encode(2)]
	public Vector3D? LinearVelocity { get; set; }

	[Encode(3)]
	public Vector3D? Orientation { get; set; }

	[Encode(4)]
	public Vector3D? Position { get; set; }

}
