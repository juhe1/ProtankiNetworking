using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class BonusRegionData : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Vector3D? Position { get; set; }

	[Encode(1)]
	public Vector3D? Rotation { get; set; }

	[Encode(2)]
	public BonusesType? RegionType { get; set; }
}
