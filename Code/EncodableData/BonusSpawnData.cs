using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BonusSpawnData : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public string? BonusId { get; set; }

	[Encode(1)]
	public int LifeTime { get; set; }

	[Encode(2)]
	public Vector3D? SpawnPosition { get; set; }

}
