using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Firebird starts shooting
    /// </summary>
    public class FireStartOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -1986638927;
        public static new string Description { get; } = "Firebird starts shooting";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 