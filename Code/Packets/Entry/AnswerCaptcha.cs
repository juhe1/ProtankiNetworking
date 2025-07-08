using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Answer the captcha
/// </summary>
public class AnswerCaptcha : AbstractPacket
{
    public static int Id { get; } = 1271163230;
    public override string Description => "Answer the captcha";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "type",
        "imagedata"
    };
}