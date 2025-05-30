using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Turret rotation data from server
    /// </summary>
    public class TurretRotatedPacket : AbstractPacket
    {
        public static new int Id { get; } = 1927704181;
        public static new string Description { get; } = "Turret rotation data from server";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(TurretRotateCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "turretRotation" };
        public static new bool ShouldLog { get; } = false;
    }
} 