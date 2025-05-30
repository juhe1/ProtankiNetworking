using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Supply box bonus id
    /// </summary>
    public class RemoveBonusBoxPacket : AbstractPacket
    {
        public static new int Id { get; } = -2026749922;
        public static new string Description { get; } = "Supply box bonus id";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "bonusId" };
    }
} 