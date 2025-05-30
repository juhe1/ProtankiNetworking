using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Respawn Delay Packet
    /// </summary>
    public class RespawnDelayPacket : AbstractPacket
    {
        public static new int Id { get; } = -173682854;
        public static new string Description { get; } = "Respawn Delay Packet";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "tank", "respawnDelay" };
    }
} 