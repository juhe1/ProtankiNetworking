using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Sends current turret rotation data to the server
    /// </summary>
    public class TurretRotationPacket : AbstractPacket
    {
        public static new int Id { get; } = -114968993;
        public static new string Description { get; } = "Sends current turret rotation data to the server";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(TurretRotateCodec), typeof(ShortCodec) };
        public static new string[] Attributes { get; } = new[] { "clientTime", "turretRotation", "incarnationID" };
        public static new bool ShouldLog { get; } = false;
    }
} 