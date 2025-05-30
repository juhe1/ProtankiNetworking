using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Sends server details about a railgun shot that has just started to release
    /// </summary>
    public class RailgunShotInitOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -1759063234;
        public static new string Description { get; } = "Sends server details about a railgun shot that has just started to release";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 