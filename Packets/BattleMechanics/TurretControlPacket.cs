using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Turret Control Packet
    /// </summary>
    public class TurretControlPacket : AbstractPacket
    {
        public static new int Id { get; } = -1749108178;
        public static new string Description { get; } = "Turret Control Packet";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(ShortCodec), typeof(ByteCodec) };
        public static new string[] Attributes { get; } = new[] { "clientTime", "specificationID", "control" };
    }
} 