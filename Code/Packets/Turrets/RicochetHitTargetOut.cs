using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Ricochet hit target (time, target, shotId, targetPosition, impactPoints).
/// </summary>
public class RicochetHitTargetOut : AbstractPacket
{
    public const int IdStatic = 1229701582;

    public override string Description =>
        "Ricochet hit target (time, target, shotId, targetPosition, impactPoints)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time (name_29)
        StringCodec.Instance, // target
        IntCodec.Instance, // shotId
        Vector3DCodec.Instance, // targetPosition (name_20)
        new VectorCodec(Vector3DCodec.Instance, true) // impactPoints (var_2664)
    };

    public override string[] Attributes => new[]
    {
        "time",
        "target",
        "shotId",
        "targetPosition",
        "impactPoints"
    };
}