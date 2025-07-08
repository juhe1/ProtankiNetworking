using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for ClientFlag structure (flagBasePosition, flagCarrierId, flagPosition).
/// </summary>
public class ClientFlagCodec : CustomBaseCodec
{
    public static ClientFlagCodec Instance { get; } = new();

    protected override string[] Attributes => new[]
    {
        "flagBasePosition",
        "flagCarrierId",
        "flagPosition"
    };

    protected override ICodec[] CodecObjects => new ICodec[]
    {
        Vector3DCodec.Instance, // flagBasePosition
        StringCodec.Instance, // flagCarrierId
        Vector3DCodec.Instance // flagPosition
    };
}