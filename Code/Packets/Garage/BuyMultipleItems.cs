using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Buy multiple items from garage, like supplies, xp boosts
/// </summary>
public class BuyMultipleItems : AbstractPacket
{
    public const int IdStatic = -1961983005;
    public override int Id => IdStatic;
    public override string Description => "Buy multiple items from garage, like supplies, xp boosts";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "item_id",
        "count",
        "base_cost"
    };
}