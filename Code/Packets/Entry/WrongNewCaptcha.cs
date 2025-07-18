using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     The captcha was incorrect, a new one is sent
/// </summary>
public class WrongNewCaptcha : AbstractPacket
{
    public static int IdStatic { get; } = -373510957;
    public override int Id => IdStatic;
    public override string Description => "The captcha was incorrect, a new one is sent";

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