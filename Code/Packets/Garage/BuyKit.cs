using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Buy a kit
/// </summary>
public class BuyKit : AbstractPacket
{
    public const int ID_CONST = -523392052;
    public override int Id => ID_CONST;
    public override string Description => "Buy a kit";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "item_id",
        "base_cost"
    };
}