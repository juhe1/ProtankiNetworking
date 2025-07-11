using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     When we start using Freeze
/// </summary>
public class FreezeStartOut : AbstractPacket
{
    public const int IdStatic = -75406982;
    public override int Id => IdStatic;
    public override string Description => "When we start using Freeze";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}