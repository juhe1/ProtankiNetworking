using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Shot Effect Applied
/// </summary>
public class ShotEffectApplied : AbstractPacket
{
    public const int ID_CONST = 546849203;
    public override int Id => ID_CONST;
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