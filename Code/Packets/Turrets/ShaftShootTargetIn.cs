using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft shooting at targets, with static hit point, target list, and impact force.
/// </summary>
public class ShaftShootTargetIn : AbstractPacket
{
    public const int ID_CONST = 1184835319;

    public override string Description =>
        "Shaft shoot at targets (shooter, staticHitPoint, targets, targetHitPoints, impactForce)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // shooter
        Vector3DCodec.Instance, // staticHitPoint
        new VectorCodec(StringCodec.Instance, true), // targets
        new VectorCodec(Vector3DCodec.Instance, true), // targetHitPoints
        FloatCodec.Instance // impactForce
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "staticHitPoint",
        "targets",
        "targetHitPoints",
        "impactForce"
    };
}