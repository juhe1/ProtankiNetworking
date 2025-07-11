using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Login information sent by the client
/// </summary>
public class Login : AbstractPacket
{
    public const int ID_CONST = -739684591;
    public override int Id => ID_CONST;
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