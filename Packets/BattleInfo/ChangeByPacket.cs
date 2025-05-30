using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Change By
    /// </summary>
    public class ChangeByPacket : AbstractPacket
    {
        public static new int Id { get; } = -593513288;
        public static new string Description { get; } = "Change By";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "changeBy" };
    }
} 