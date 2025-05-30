using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Buy from shop
    /// </summary>
    public class BuyFromShopPacket : AbstractPacket
    {
        public static new int Id { get; } = 921004371;
        public static new string Description { get; } = "Buy from shop";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "location_abbreviation" };
    }
} 