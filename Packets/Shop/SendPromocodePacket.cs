using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Shop
{
    /// <summary>
    /// Client uses a promocode
    /// </summary>
    public class SendPromocodePacket : AbstractPacket
    {
        public static new int Id { get; } = -511004908;
        public static new string Description { get; } = "Client uses a promocode";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "promocode" };
    }
} 