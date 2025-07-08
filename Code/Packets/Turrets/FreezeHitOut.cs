using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Freeze hit out (time, targets, incarnations, positions, hitPoints).
/// </summary>
public class FreezeHitOut : AbstractPacket
{
    public static int Id { get; } = 1395251766;
    public override string Description => "Freeze hit out (time, targets, incarnations, positions, hitPoints)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        new VectorCodec(StringCodec.Instance, true), // targets
        new VectorCodec(ShortCodec.Instance, true), // incarnations (var_1046)
        new VectorCodec(Vector3DCodec.Instance, true), // positions (var_2788)
        new VectorCodec(Vector3DCodec.Instance, true) // hitPoints (var_778)
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