using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Request a captcha
/// </summary>
public class RequestCaptcha : AbstractPacket
{
    public static int Id { get; } = -349828108;
    public override string Description => "Request a captcha";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "type"
    };
}