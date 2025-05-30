using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Vulcan starts shooting
    /// </summary>
    public class VulcanStartOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -520655432;
        public static new string Description { get; } = "Vulcan starts shooting";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 