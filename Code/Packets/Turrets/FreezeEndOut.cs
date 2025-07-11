using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     When we stop using Freeze
/// </summary>
public class FreezeEndOut : AbstractPacket
{
    public const int ID_CONST = -1654947652;
    public override int Id => ID_CONST;
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