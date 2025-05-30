using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Change location in shop
    /// </summary>
    public class ChangeShopLocationPacket : AbstractPacket
    {
        public static new int Id { get; } = 880756819;
        public static new string Description { get; } = "Change location in shop";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "itemId", "itemType" };
    }
} 