using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Information about the ping of the player
    /// </summary>
    public class BattlePingInfoPacket : AbstractPacket
    {
        public static new int Id { get; } = 34068208;
        public static new string Description { get; } = "Information about the ping of the player.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorIntPairCodec) };
        public static new string[] Attributes { get; } = new[] { "latencyInfo" };
        public static new bool ShouldLog { get; } = false;
    }
} 