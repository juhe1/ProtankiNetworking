using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// A bonus box has dropped
    /// </summary>
    public class BonusBoxDroppedPacket : AbstractPacket
    {
        public static new int Id { get; } = 1831462385;
        public static new string Description { get; } = "A bonus box has dropped";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(Vector3DCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "bonusId", "position", "fallTimeThreshold" };
    }
} 