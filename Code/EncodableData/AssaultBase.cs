using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class AssaultBase : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int Id { get; set; }

	[Encode(1)]
	public Vector3D? Position { get; set; }

}
