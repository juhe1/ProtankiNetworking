using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Codec.Custom;

/// <summary>
///     Codec for turretrotate
/// </summary>
public class TurretRotateCodec : CustomBaseCodec
{
    /// <summary>
    ///     Creates a new instance of TurretRotateCodec
    /// </summary>
    private TurretRotateCodec()
    {
    }

    /// <summary>
    ///     Gets the singleton instance of TurretRotateCodec
    /// </summary>
    public static TurretRotateCodec Instance { get; } = new();

    /// <summary>
    ///     Gets the list of attribute names for this codec
    /// </summary>
    protected override string[] Attributes => new[]
    {
        "angle",
        "control"
    };

    /// <summary>
    ///     Gets the list of codec objects for this codec
    /// </summary>
    protected override ICodec[] CodecObjects => new ICodec[]
    {
        FloatCodec.Instance,
        ByteCodec.Instance
    };
}