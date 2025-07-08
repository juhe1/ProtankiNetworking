using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Captcha is correct
/// </summary>
public class CaptchaCorrect : AbstractPacket
{
    public static int IdStatic { get; } = -819536476;
    public override int Id => IdStatic;
    public override string Description => "Captcha is correct";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "type"
    };
}