using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Garage
{
    /// <summary>
    /// Buy multiple items from garage, like supplies, xp boosts
    /// </summary>
    public class BuyMultipleItemsPacket : AbstractPacket
    {
        public static new int Id { get; } = -1961983005;
        public static new string Description { get; } = "Buy multiple items from garage, like supplies, xp boosts";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "item_id", "count", "base_cost" };
    }
} 