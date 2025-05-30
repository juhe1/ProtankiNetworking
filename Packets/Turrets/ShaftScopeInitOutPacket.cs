using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Initiates a shaft scope shot
    /// </summary>
    public class ShaftScopeInitOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -367760678;
        public static new string Description { get; } = "Initiates a shaft scope shot";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 