using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class MoveData : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Vector3D? AngV { get; set; }

	[Encode(1)]
	public byte Control { get; set; }

	[Encode(2)]
	public Vector3D? LinV { get; set; }

	[Encode(3)]
	public Vector3D? Orientation { get; set; }

	[Encode(4)]
	public Vector3D? Pos { get; set; }
}
