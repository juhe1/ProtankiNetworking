using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Captcha is correct
/// </summary>
public class CaptchaCorrect : AbstractPacket
{
    public static int Id { get; } = -819536476;
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