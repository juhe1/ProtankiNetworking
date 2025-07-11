using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Firebird attack
/// </summary>
public class FlamethrowerDamage : AbstractPacket
{
    public const int ID_CONST = 1395251766;
    public override int Id => ID_CONST;
    public override string Description => "Firebird attack";

    public override ICodec[] CodecObjects => new ICodec[]
    {
        IntCodec.Instance,
        new VectorCodec(StringCodec.Instance, true),
        new VectorCodec(ShortCodec.Instance, true),
        new VectorCodec(Vector3DCodec.Instance, true),
        new VectorCodec(Vector3DCodec.Instance, true)
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "targets",
        "incarnationIDs",
        "targetBodyPositions",
        "targetHitPoints"
    };
}