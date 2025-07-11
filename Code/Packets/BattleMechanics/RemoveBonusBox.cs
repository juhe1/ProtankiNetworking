using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Supply box bonus id
/// </summary>
public class RemoveBonusBox : AbstractPacket
{
    public const int ID_CONST = -2026749922;
    public override int Id => ID_CONST;
    public override string Description => "Supply box bonus id";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "bonusId"
    };
}