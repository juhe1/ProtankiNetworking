using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Collect a crystal box
/// </summary>
public class CollectCryBox : AbstractPacket
{
    public const int ID_CONST = -1047185003;
    public override int Id => ID_CONST;
    public override string Description => "Collect a crystal box";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "bonusId"
    };
}