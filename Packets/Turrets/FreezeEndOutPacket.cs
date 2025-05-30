using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// When we stop using Freeze
    /// </summary>
    public class FreezeEndOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -1654947652;
        public static new string Description { get; } = "When we stop using Freeze";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 