using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Garage
{
    /// <summary>
    /// Buy a kit
    /// </summary>
    public class BuyKitPacket : AbstractPacket
    {
        public static new int Id { get; } = -523392052;
        public static new string Description { get; } = "Buy a kit";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "item_id", "base_cost" };
    }
} 