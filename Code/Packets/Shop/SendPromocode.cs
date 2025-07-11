using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Shop;

/// <summary>
///     Client uses a promocode
/// </summary>
public class SendPromocode : AbstractPacket
{
    public const int IdStatic = -511004908;
    public override int Id => IdStatic;
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