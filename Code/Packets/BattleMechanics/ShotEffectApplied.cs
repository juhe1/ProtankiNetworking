using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Shot Effect Applied
/// </summary>
public class ShotEffectApplied : AbstractPacket
{
    public static int IdStatic { get; } = 546849203;
    public override int Id => IdStatic;
    public override string Description => "Shot Effect Applied";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        Vector3DCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "shooter",
        "hitPoint"
    };
}