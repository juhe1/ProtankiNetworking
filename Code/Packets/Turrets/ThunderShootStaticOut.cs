using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder shoot static (time, hitPoint).
/// </summary>
public class ThunderShootStaticOut : AbstractPacket
{
    public const int ID_CONST = 1501310158;
    public override int Id => ID_CONST;
    public override string Description => "Thunder shoot static (time, hitPoint)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time (was var_2174)
        Vector3DCodec.Instance // hitPoint
    };

    public override string[] Attributes => new[]
    {
        "time",
        "hitPoint"
    };
}