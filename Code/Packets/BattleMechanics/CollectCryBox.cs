using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Collect a crystal box
/// </summary>
public class CollectCryBox : AbstractPacket
{
    public static int IdStatic { get; } = -1047185003;
    public override int Id => IdStatic;
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