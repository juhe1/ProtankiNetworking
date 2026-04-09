using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class ControlPointsCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public float KeypointTriggerRadius { get; set; }

	[Encode(1)]
	public float KeypointVisorHeight { get; set; }

	[Encode(2)]
	public float MinesRestrictionRadius { get; set; }

	[Encode(3)]
	public ClientPointData?[]? Points { get; set; }

	[Encode(4)]
	public DominationResources? Resources { get; set; }

	[Encode(5)]
	public DominationSounds? Sounds { get; set; }

}
