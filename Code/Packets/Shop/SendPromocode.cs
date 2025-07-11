using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Shop;

/// <summary>
///     Client uses a promocode
/// </summary>
public class SendPromocode : AbstractPacket
{
    public const int ID_CONST = -511004908;
    public override int Id => ID_CONST;
    public override string Description => "Client uses a promocode";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "promocode"
    };
}