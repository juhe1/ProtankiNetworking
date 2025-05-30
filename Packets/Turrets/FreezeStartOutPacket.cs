using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// When we start using Freeze
    /// </summary>
    public class FreezeStartOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -75406982;
        public static new string Description { get; } = "When we start using Freeze";
        public static new string[] Attributes { get; } = new[] { "clientTime" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
    }
} 