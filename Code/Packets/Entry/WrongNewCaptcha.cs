using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     The captcha was incorrect, a new one is sent
/// </summary>
public class WrongNewCaptcha : AbstractPacket
{
    public const int ID_CONST = -373510957;
    public override int Id => ID_CONST;
    public override string Description => "The captcha was incorrect, a new one is sent";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        CaptchaLocationCodec.Instance,
        new VectorCodec(ByteCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "location",
        "imagedata"
    };
}