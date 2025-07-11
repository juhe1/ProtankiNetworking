using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Firebird starts shooting
/// </summary>
public class FlamethrowerStartOut : AbstractPacket
{
    public static int IdStatic { get; } = -1986638927;
    public override int Id => IdStatic;
    public override string Description => "Firebird starts shooting";

    public override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}