using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Get shop info
    /// </summary>
    public class ShopInfoPacket : AbstractPacket
    {
        public static new int Id { get; } = 1863710730;
        public static new string Description { get; } = "Get shop info";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "data" };
    }
} 