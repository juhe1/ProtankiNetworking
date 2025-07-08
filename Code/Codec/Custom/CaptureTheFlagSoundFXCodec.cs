using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for CaptureTheFlagSoundFX structure used in CTF configuration.
/// </summary>
public class CaptureTheFlagSoundFXCodec : CustomBaseCodec
{
    private CaptureTheFlagSoundFXCodec()
    {
    }

    public static CaptureTheFlagSoundFXCodec Instance { get; } = new();

    protected override string[] Attributes => new[]
    {
        "flagDropSound",
        "flagReturnSound",
        "flagTakeSound",
        "winSound"
    };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance, // flagDropSound
        IntCodec.Instance, // flagReturnSound
        IntCodec.Instance, // flagTakeSound
        IntCodec.Instance // winSound
    };
}