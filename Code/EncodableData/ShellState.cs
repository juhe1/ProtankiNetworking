using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class ShellState : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public Vector3D? Direction { get; set; }

	[Encode(2)]
	public Vector3D? Position { get; set; }

}
