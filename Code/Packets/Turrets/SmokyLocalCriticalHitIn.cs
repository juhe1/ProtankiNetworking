using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Smoky local critical hit in (target).
/// </summary>
public class SmokyLocalCriticalHitIn : AbstractPacket
{
    public static int IdStatic { get; } = -671618989;
    public override int Id => IdStatic;
    public override string Description => "Smoky local critical hit in (target)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // target
    };

    public override string[] Attributes => new[]
    {
        "target"
    };
}