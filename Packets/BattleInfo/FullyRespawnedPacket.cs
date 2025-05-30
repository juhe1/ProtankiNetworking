using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Packet sent when the player has fully respawned
    /// </summary>
    public class FullyRespawnedPacket : AbstractPacket
    {
        public static new int Id { get; } = 1868573511;
        public static new string Description { get; } = "Packet sent when the player has fully respawned";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 