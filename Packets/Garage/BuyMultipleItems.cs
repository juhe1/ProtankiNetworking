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
        public static new int Id { get; } = -1961983005;
        public static new string Description { get; } = "Buy multiple items from garage, like supplies, xp boosts";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "item_id",
            "count",
            "base_cost",
        };
    }
}
