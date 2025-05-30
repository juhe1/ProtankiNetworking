using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Battle time left in seconds
    /// </summary>
    public class BattleTimeLeftPacket : AbstractPacket
    {
        public static new int Id { get; } = 732434644;
        public static new string Description { get; } = "Battle time left in seconds";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "timeLimitInSec" };
    }
} 