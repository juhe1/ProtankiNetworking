using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Contains the keys required to activate packet encryption
/// </summary>
public class ActivateProtection : AbstractPacket
{
    public static int IdStatic { get; } = 2001736388;
    public override int Id => IdStatic;
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