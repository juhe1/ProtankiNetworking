using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     A bonus box was picked up
/// </summary>
public class CollectedBonusBox : AbstractPacket
{
    public const int IdStatic = -1291499147;
    public override int Id => IdStatic;
    public override string Description => "A bonus box was picked up";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "bonusId"
    };
}