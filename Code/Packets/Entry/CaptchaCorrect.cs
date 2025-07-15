using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Captcha is correct
/// </summary>
public class CaptchaCorrect : AbstractPacket
{
    public const int ID_CONST = -819536476;
    public override int Id => ID_CONST;
    public override string Description => "Captcha is correct";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        CaptchaLocationCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "location"
    };
}