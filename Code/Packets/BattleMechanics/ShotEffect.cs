using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Shot effect packet
/// </summary>
public class ShotEffect : AbstractPacket
{
    public static int IdStatic { get; } = -1994318624;
    public override int Id => IdStatic;
    public override string Description => "Shot effect packet";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "effectId"
    };
}