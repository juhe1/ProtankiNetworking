using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Server syncs tank movement stats with client
    /// </summary>
    public class TankStatSyncedPacket : AbstractPacket
    {
        public static new int Id { get; } = -1672577397;
        public static new string Description { get; } = "Server syncs tank movement stats with client";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(FloatCodec), typeof(FloatCodec), typeof(FloatCodec), typeof(FloatCodec), typeof(ShortCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "maxSpeed", "maxTurnSpeed", "maxTurretRotationSpeed", "acceleration", "specificationID" };
    }
} 