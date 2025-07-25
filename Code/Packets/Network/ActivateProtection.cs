using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Contains the keys required to activate packet encryption
/// </summary>
public class ActivateProtection : AbstractPacket
{
    public const int ID_CONST = 2001736388;
    public override int Id => ID_CONST;
    public override string Description => "Contains the keys required to activate packet encryption";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(ByteCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "keys"
    };
}