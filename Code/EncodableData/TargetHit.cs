using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class TargetHit : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Vector3D? Direction { get; set; }

	[Encode(1)]
	public Vector3D? LocalHitPoint { get; set; }

	[Encode(2)]
	public byte NumberHits { get; set; }

	[Encode(3)]
	public string? Target { get; set; }
}
