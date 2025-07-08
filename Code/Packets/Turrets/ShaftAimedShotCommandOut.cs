using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft aimed shot command out (time, staticHitPoint, targets, targetHitPoints, targetIncarnation,
///     targetPosition, hitPointWorld).
/// </summary>
public class ShaftAimedShotCommandOut : AbstractPacket
{
    public static int IdStatic { get; } = 1632423559;

    public override string Description =>
        "Shaft aimed shot command out (time, staticHitPoint, targets, targetHitPoints, targetIncarnation, targetPosition, hitPointWorld)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        Vector3DCodec.Instance, // staticHitPoint
        new VectorCodec(StringCodec.Instance, true), // targets
        new VectorCodec(Vector3DCodec.Instance, true), // targetHitPoints
        new VectorCodec(ShortCodec.Instance, true), // targetIncarnation (name_61)
        new VectorCodec(Vector3DCodec.Instance, true), // targetPosition (var_2788)
        new VectorCodec(Vector3DCodec.Instance, true) // hitPointWorld (var_778)
    };

    public override string[] Attributes => new[]
    {
        "time",
        "staticHitPoint",
        "targets",
        "targetHitPoints",
        "targetIncarnation",
        "targetPosition",
        "hitPointWorld"
    };
}