using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class BattleMine : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public string? MineId { get; set; }

	[Encode(1)]
	public string? OwnerId { get; set; }

	[Encode(2)]
	public Vector3D? Position { get; set; }
}
