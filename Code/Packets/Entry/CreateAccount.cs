using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Create new account
/// </summary>
public class CreateAccount : AbstractPacket
{
    public static int IdStatic { get; } = 427083290;
    public override int Id => IdStatic;
    public override string Description => "Create new account";

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