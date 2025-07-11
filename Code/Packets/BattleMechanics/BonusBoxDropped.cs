using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     A bonus box has dropped
/// </summary>
public class BonusBoxDropped : AbstractPacket
{
    public const int IdStatic = 1831462385;
    public override int Id => IdStatic;
    public override string Description => "A bonus box has dropped";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        Vector3DCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "bonusId",
        "position",
        "fallTimeThreshold"
    };
}