using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Garage
{
    /// <summary>
    /// Buy multiple items from garage, like supplies, xp boosts
    /// </summary>
    public class BuyMultipleItems : AbstractPacket
    {
        public static int Id { get; } = -1961983005;
        public override string Description => "Buy multiple items from garage, like supplies, xp boosts";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "item_id",
            "count",
            "base_cost",
        };
    }
}
