using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder hit target out (time, relativeHitPoint, target, incarnation, targetPosition, hitPointWorld).
/// </summary>
public class ThunderHitTargetOut : AbstractPacket
{
    public const int IdStatic = 259979915;

    public override string Description =>
        "Thunder hit target out (time, relativeHitPoint, target, incarnation, targetPosition, hitPointWorld)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time (var_2174)
        Vector3DCodec.Instance, // relativeHitPoint
        StringCodec.Instance, // target
        ShortCodec.Instance, // incarnation (var_350)
        Vector3DCodec.Instance, // targetPosition (name_20)
        Vector3DCodec.Instance // hitPointWorld (var_3151)
    };

    public override string[] Attributes => new[]
    {
        "time",
        "relativeHitPoint",
        "target",
        "incarnation",
        "targetPosition",
        "hitPointWorld"
    };
}