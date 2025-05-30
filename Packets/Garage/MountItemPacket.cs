using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Garage
{
    /// <summary>
    /// Mount an item in garage
    /// </summary>
    public class MountItemPacket : AbstractPacket
    {
        public static new int Id { get; } = -1505530736;
        public static new string Description { get; } = "Mount an item in garage";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "item_id" };
    }
} 