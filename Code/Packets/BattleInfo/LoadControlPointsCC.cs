

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
    public int BigLetters { get; set; }

    [Encode(5)]
    public int BlueCircle { get; set; }

    [Encode(6)]
    public int BluePedestalTexture { get; set; }

    [Encode(7)]
    public int BlueRay { get; set; }

    [Encode(8)]
    public int BlueRayTip { get; set; }

    [Encode(9)]
    public int NeutralCircle { get; set; }

    [Encode(10)]
    public int NeutralPedestalTexture { get; set; }

    [Encode(11)]
    public int Pedestal { get; set; }

    [Encode(12)]
    public int RedCircle { get; set; }

    [Encode(13)]
    public int RedPedestalTexture { get; set; }

    [Encode(14)]
    public int RedRay { get; set; }

    [Encode(15)]
    public int RedRayTip { get; set; }

    [Encode(16)]
    public int PointCaptureStartNegativeSound { get; set; }

    [Encode(17)]
    public int PointCaptureStartPositiveSound { get; set; }

    [Encode(18)]
    public int PointCaptureStopNegativeSound { get; set; }

    [Encode(19)]
    public int PointCaptureStopPositiveSound { get; set; }

    [Encode(20)]
    public int PointCapturedNegativeSound { get; set; }

    [Encode(21)]
    public int PointCapturedPositiveSound { get; set; }

    [Encode(22)]
    public int PointNeutralizedNegativeSound { get; set; }

    [Encode(23)]
    public int PointNeutralizedPositiveSound { get; set; }

    [Encode(24)]
    public int PointScoreDecreasingSound { get; set; }

    [Encode(25)]
    public int PointScoreIncreasingSound { get; set; }

    public const int ID_CONST = -1337059439;
    public override int Id => ID_CONST;
    public override string Description => "Load control points configuration (ControlPointsCC)";


}