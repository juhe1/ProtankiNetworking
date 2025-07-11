using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     email
/// </summary>
public class Email : AbstractPacket
{
    public const int ID_CONST = 613462801;
    public override int Id => ID_CONST;
    public override string Description => "email";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "email",
        "emailConfirmed"
    };
}