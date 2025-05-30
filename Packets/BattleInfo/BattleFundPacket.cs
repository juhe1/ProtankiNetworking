using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Packet containing battle fund information
    /// </summary>
    public class BattleFundPacket : AbstractPacket
    {
        public static new int Id { get; } = 1149211509;
        public static new string Description { get; } = "Battle fund";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "fund" };
    }
} 