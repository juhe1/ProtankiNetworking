using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Sets captcha hash keys
/// </summary>
public class SetCaptchaKeys : AbstractPacket
{
    public static int IdStatic { get; } = 321971701;
    public override int Id => IdStatic;
    public override string Description => "Sets captcha hash keys";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(IntCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "keys"
    };
}