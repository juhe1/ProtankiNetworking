using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Effect Aftermath
/// </summary>
public class EffectAftermath : AbstractPacket
{
    public static int Id { get; } = -1639713644;
    public override string Description => "Effect Aftermath";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance,
        BoolCodec.Instance,
        ByteCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "effectId",
        "duration",
        "activeAfterDeath",
        "effectLevel"
    };
}