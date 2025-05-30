using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Smokey Shoot at Air
    /// </summary>
    public class SmokyShootAirOutPacket : AbstractPacket
    {
        public static new int Id { get; } = 1478921140;
        public static new string Description { get; } = "Smokey Shoot at Air";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 