using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Received a captcha image with its type
/// </summary>
public class ReceiveCaptcha : AbstractPacket
{
    public static int IdStatic { get; } = -1670408519;
    public override int Id => IdStatic;
    public override string Description => "Received a captcha image with its type";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        new VectorCodec(ByteCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "type",
        "imagedata"
    };
}