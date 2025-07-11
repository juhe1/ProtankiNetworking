using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading control points configuration (ControlPointsCC).
/// </summary>
public class LoadControlPointsCC : AbstractPacket
{
    public const int ID_CONST = -1337059439;
    public override int Id => ID_CONST;
    public override string Description => "Load control points configuration (ControlPointsCC)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        FloatCodec.Instance, // keypointTriggerRadius
        FloatCodec.Instance, // keypointVisorHeight
        FloatCodec.Instance, // minesRestrictionRadius
        new VectorCodec(IntCodec.Instance, false), // points (Vector<ClientPointData>), placeholder as IntCodec
        // DominationResources
        IntCodec.Instance, // bigLetters (ResourceGetterCodec)
        IntCodec.Instance, // blueCircle (ResourceGetterCodec)
        IntCodec.Instance, // bluePedestalTexture (ResourceGetterCodec)
        IntCodec.Instance, // blueRay (ResourceGetterCodec)
        IntCodec.Instance, // blueRayTip (ResourceGetterCodec)
        IntCodec.Instance, // neutralCircle (ResourceGetterCodec)
        IntCodec.Instance, // neutralPedestalTexture (ResourceGetterCodec)
        IntCodec.Instance, // pedestal (ResourceGetterCodec)
        IntCodec.Instance, // redCircle (ResourceGetterCodec)
        IntCodec.Instance, // redPedestalTexture (ResourceGetterCodec)
        IntCodec.Instance, // redRay (ResourceGetterCodec)
        IntCodec.Instance, // redRayTip (ResourceGetterCodec)
        // DominationSounds
        IntCodec.Instance, // pointCaptureStartNegativeSound (ResourceGetterCodec)
        IntCodec.Instance, // pointCaptureStartPositiveSound (ResourceGetterCodec)
        IntCodec.Instance, // pointCaptureStopNegativeSound (ResourceGetterCodec)
        IntCodec.Instance, // pointCaptureStopPositiveSound (ResourceGetterCodec)
        IntCodec.Instance, // pointCapturedNegativeSound (ResourceGetterCodec)
        IntCodec.Instance, // pointCapturedPositiveSound (ResourceGetterCodec)
        IntCodec.Instance, // pointNeutralizedNegativeSound (ResourceGetterCodec)
        IntCodec.Instance, // pointNeutralizedPositiveSound (ResourceGetterCodec)
        IntCodec.Instance, // pointScoreDecreasingSound (ResourceGetterCodec)
        IntCodec.Instance // pointScoreIncreasingSound (ResourceGetterCodec)
    };

    public override string[] Attributes => new[]
    {
        "keypointTriggerRadius",
        "keypointVisorHeight",
        "minesRestrictionRadius",
        "points",
        // DominationResources
        "bigLetters",
        "blueCircle",
        "bluePedestalTexture",
        "blueRay",
        "blueRayTip",
        "neutralCircle",
        "neutralPedestalTexture",
        "pedestal",
        "redCircle",
        "redPedestalTexture",
        "redRay",
        "redRayTip",
        // DominationSounds
        "pointCaptureStartNegativeSound",
        "pointCaptureStartPositiveSound",
        "pointCaptureStopNegativeSound",
        "pointCaptureStopPositiveSound",
        "pointCapturedNegativeSound",
        "pointCapturedPositiveSound",
        "pointNeutralizedNegativeSound",
        "pointNeutralizedPositiveSound",
        "pointScoreDecreasingSound",
        "pointScoreIncreasingSound"
    };
}