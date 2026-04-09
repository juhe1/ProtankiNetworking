using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class DominationSounds : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public Resource? PointCaptureStartNegativeSound { get; set; }

	[Encode(1)]
	public Resource? PointCaptureStartPositiveSound { get; set; }

	[Encode(2)]
	public Resource? PointCaptureStopNegativeSound { get; set; }

	[Encode(3)]
	public Resource? PointCaptureStopPositiveSound { get; set; }

	[Encode(4)]
	public Resource? PointCapturedNegativeSound { get; set; }

	[Encode(5)]
	public Resource? PointCapturedPositiveSound { get; set; }

	[Encode(6)]
	public Resource? PointNeutralizedNegativeSound { get; set; }

	[Encode(7)]
	public Resource? PointNeutralizedPositiveSound { get; set; }

	[Encode(8)]
	public Resource? PointScoreDecreasingSound { get; set; }

	[Encode(9)]
	public Resource? PointScoreIncreasingSound { get; set; }

}
