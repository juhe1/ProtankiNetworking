using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading control points configuration (ControlPointsCC).
/// </summary>
public class LoadControlPointsCC : Packet
{
	[Encode(0)]
	public float KeypointTriggerRadius { get; set; }

	[Encode(1)]
	public float KeypointVisorHeight { get; set; }

	[Encode(2)]
	public float MinesRestrictionRadius { get; set; }

	[Encode(3)]
	public int[]? Points { get; set; }

	[Encode(4)]
	public Resource? BigLetters { get; set; }

	[Encode(5)]
	public Resource? BlueCircle { get; set; }

	[Encode(6)]
	public Resource? BluePedestalTexture { get; set; }

	[Encode(7)]
	public Resource? BlueRay { get; set; }

	[Encode(8)]
	public Resource? BlueRayTip { get; set; }

	[Encode(9)]
	public Resource? NeutralCircle { get; set; }

	[Encode(10)]
	public Resource? NeutralPedestalTexture { get; set; }

	[Encode(11)]
	public Resource? Pedestal { get; set; }

	[Encode(12)]
	public Resource? RedCircle { get; set; }

	[Encode(13)]
	public Resource? RedPedestalTexture { get; set; }

	[Encode(14)]
	public Resource? RedRay { get; set; }

	[Encode(15)]
	public Resource? RedRayTip { get; set; }

	[Encode(16)]
	public Resource? PointCaptureStartNegativeSound { get; set; }

	[Encode(17)]
	public Resource? PointCaptureStartPositiveSound { get; set; }

	[Encode(18)]
	public Resource? PointCaptureStopNegativeSound { get; set; }

	[Encode(19)]
	public Resource? PointCaptureStopPositiveSound { get; set; }

	[Encode(20)]
	public Resource? PointCapturedNegativeSound { get; set; }

	[Encode(21)]
	public Resource? PointCapturedPositiveSound { get; set; }

	[Encode(22)]
	public Resource? PointNeutralizedNegativeSound { get; set; }

	[Encode(23)]
	public Resource? PointNeutralizedPositiveSound { get; set; }

	[Encode(24)]
	public Resource? PointScoreDecreasingSound { get; set; }

	[Encode(25)]
	public Resource? PointScoreIncreasingSound { get; set; }

	public const int ID_CONST = -1337059439;
	public override int Id => ID_CONST;
	public override string Description => "Load control points configuration (ControlPointsCC)";
}
