using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for hitting a target: time, shotId, target, targetPosition, hitPointWorld. Used in Twins and Ricochet.
/// </summary>
public class HitTargetCommand : AbstractPacket
{
    public const int ID_CONST = -1723353904;

    public override string Description =>
        "Hit target command (time, shotId, target, targetPosition, hitPointWorld). Used in Twins and Ricochet.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        IntCodec.Instance, // shotId
        StringCodec.Instance, // target
        Vector3DCodec.Instance, // targetPosition
        Vector3DCodec.Instance // hitPointWorld
    };

    public override string[] Attributes => new[]
    {
        "time",
        "shotId",
        "target",
        "targetPosition",
        "hitPointWorld"
    };
}