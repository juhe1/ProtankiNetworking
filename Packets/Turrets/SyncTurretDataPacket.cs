using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Syncs turret data to the client
    /// </summary>
    public class SyncTurretDataPacket : AbstractPacket
    {
        public static new int Id { get; } = -2124388778;
        public static new string Description { get; } = "Syncs turret data to the client";
        public static new string[] Attributes { get; } = new[] { "json" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
    }
} 