using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for stream weapon hit (time, targets, incarnations, positions, hitPoints). Freeze and Flamethrower uses
///     this.
/// </summary>
public class StreamWeaponHit : AbstractPacket
{
    public const int ID_CONST = -2123941185;

    public override string Description =>
        "Stream weapon hit (time, targets, incarnations, positions, hitPoints). Freeze and Flamethrower uses this.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        new VectorCodec(StringCodec.Instance, true), // targets
        new VectorCodec(ShortCodec.Instance, true), // incarnations
        new VectorCodec(Vector3DCodec.Instance, true), // positions
        new VectorCodec(Vector3DCodec.Instance, true) // hitPoints
    };

    public override string[] Attributes => new[]
    {
        "time",
        "targets",
        "incarnations",
        "positions",
        "hitPoints"
    };
}