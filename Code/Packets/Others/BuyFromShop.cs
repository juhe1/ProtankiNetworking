using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Change location in shop
/// </summary>
public class BuyFromShop : AbstractPacket
{
    public const int ID_CONST = 880756819;
    public override int Id => ID_CONST;
    public override string Description => "Change location in shop";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "itemId",
        "itemType"
    };
}