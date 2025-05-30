using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// A bonus box was picked up
    /// </summary>
    public class CollectedBonusBoxPacket : AbstractPacket
    {
        public static new int Id { get; } = -1291499147;
        public static new string Description { get; } = "A bonus box was picked up";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "bonusId" };
    }
} 