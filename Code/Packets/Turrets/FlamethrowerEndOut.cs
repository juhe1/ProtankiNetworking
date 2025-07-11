using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Firebird stops shooting
/// </summary>
public class FlamethrowerEndOut : AbstractPacket
{
    public const int IdStatic = -1300958299;
    public override int Id => IdStatic;
    public override string Description => "Firebird stops shooting";

    public override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}