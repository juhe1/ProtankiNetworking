using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading Capture The Flag control center.
/// </summary>
public class LoadCaptureTheFlagCC : AbstractPacket
{
    public const int ID_CONST = 789790814;
    public override int Id => ID_CONST;
    public override string Description => "Load Capture The Flag control center";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        ClientFlagCodec.Instance, // blueFlag
        IntCodec.Instance, // blueFlagSprite (ResourceGetterCodec)
        IntCodec.Instance, // bluePedestalModel (ResourceGetterCodec)
        ClientFlagCodec.Instance, // redFlag
        IntCodec.Instance, // redFlagSprite (ResourceGetterCodec)
        IntCodec.Instance, // redPedestalModel (ResourceGetterCodec)
        CaptureTheFlagSoundFXCodec.Instance // sounds
    };

    public override string[] Attributes => new[]
    {
        "blueFlag",
        "blueFlagSprite",
        "bluePedestalModel",
        "redFlag",
        "redFlagSprite",
        "redPedestalModel",
        "sounds"
    };
}