using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Purchasable Items
/// </summary>
public class LoadPurchasableItems : AbstractPacket
{
    public static int IdStatic { get; } = -300370823;
    public override int Id => IdStatic;
    public override string Description => "Load Purchasable Items";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}