using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Vulcan stops shooting
    /// </summary>
    public class VulcanEndOutPacket : AbstractPacket
    {
        public static new int Id { get; } = 1794372798;
        public static new string Description { get; } = "Vulcan stops shooting";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 