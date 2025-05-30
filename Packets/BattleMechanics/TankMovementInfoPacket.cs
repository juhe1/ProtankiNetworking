using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Client moved passively
    /// </summary>
    public class TankMovementInfoPacket : AbstractPacket
    {
        public static new int Id { get; } = -1683279062;
        public static new string Description { get; } = "Client moved passively";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(ShortCodec), typeof(MoveCodec), typeof(FloatCodec) };
        public static new string[] Attributes { get; } = new[] { "clientTime", "specificationID", "movement", "turretDirection" };
    }
} 