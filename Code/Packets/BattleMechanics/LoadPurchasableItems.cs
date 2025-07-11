using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Purchasable Items
/// </summary>
public class LoadPurchasableItems : AbstractPacket
{
    public const int ID_CONST = -300370823;
    public override int Id => ID_CONST;
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