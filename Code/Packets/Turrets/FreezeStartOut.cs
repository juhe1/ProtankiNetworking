using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     When we start using Freeze
/// </summary>
public class FreezeStartOut : AbstractPacket
{
    public const int ID_CONST = -75406982;
    public override int Id => ID_CONST;
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