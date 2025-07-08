using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Login information sent by the client
/// </summary>
public class Login : AbstractPacket
{
    public static int IdStatic { get; } = -739684591;
    public override int Id => IdStatic;
    public override string Description => "Login information sent by the client";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance,
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "password",
        "rememberMe"
    };
}