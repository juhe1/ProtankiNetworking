using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Firebird stops shooting
/// </summary>
public class FlamethrowerEndOut : AbstractPacket
{
    public const int ID_CONST = -1300958299;
    public override int Id => ID_CONST;
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