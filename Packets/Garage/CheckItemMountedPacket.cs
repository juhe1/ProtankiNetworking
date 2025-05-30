using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Garage
{
    /// <summary>
    /// If the mount was successful or not
    /// </summary>
    public class CheckItemMountedPacket : AbstractPacket
    {
        public static new int Id { get; } = 2062201643;
        public static new string Description { get; } = "If the mount was successful or not";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(BoolCodec) };
        public static new string[] Attributes { get; } = new[] { "item_id", "mounted" };
    }
} 