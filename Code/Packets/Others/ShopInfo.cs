using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Get shop info
/// </summary>
public class ShopInfo : AbstractPacket
{
    public const int ID_CONST = 1863710730;
    public override int Id => ID_CONST;
    public override string Description => "Get shop info";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "data"
    };
}