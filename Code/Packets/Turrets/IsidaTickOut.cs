using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida tick out event.
/// </summary>
public class IsidaTickOut : AbstractPacket
{
    public const int ID_CONST = 244072998;
    public override int Id => ID_CONST;
    public override string Description => "Send Isida tick out event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        ShortCodec.Instance, // targetIncarnation
        Vector3DCodec.Instance, // targetPosition
        Vector3DCodec.Instance // localHitPoint
    };

    public override string[] Attributes => new[]
    {
        "time",
        "targetIncarnation",
        "targetPosition",
        "localHitPoint"
    };
}