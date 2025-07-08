using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Do we need an invite code to access the server?
/// </summary>
public class InviteCodeStatus : AbstractPacket
{
    public static int IdStatic { get; } = 444933603;
    public override int Id => IdStatic;
    public override string Description => "Do we need an invite code to access the server?";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "inviteEnabled"
    };
}