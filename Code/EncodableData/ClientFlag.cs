using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class ClientFlag : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Vector3D? FlagBasePosition { get; set; }

	[Encode(1)]
	public string? FlagCarrierId { get; set; }

	[Encode(2)]
	public Vector3D? FlagPosition { get; set; }
}
