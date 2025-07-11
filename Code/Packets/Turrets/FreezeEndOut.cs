using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     When we stop using Freeze
/// </summary>
public class FreezeEndOut : AbstractPacket
{
    public const int IdStatic = -1654947652;
    public override int Id => IdStatic;
    public override string Description => "When we stop using Freeze";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime"
    };
}