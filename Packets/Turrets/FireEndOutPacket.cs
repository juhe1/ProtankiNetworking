using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Firebird stops shooting
    /// </summary>
    public class FireEndOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -1300958299;
        public static new string Description { get; } = "Firebird stops shooting";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 