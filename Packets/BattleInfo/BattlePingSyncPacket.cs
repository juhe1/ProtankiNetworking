using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Attempts to sync ping information with the server
    /// </summary>
    public class BattlePingSyncPacket : AbstractPacket
    {
        public static new int Id { get; } = 2074243318;
        public static new string Description { get; } = "Attempts to sync ping information with the server";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorIntPairCodec) };
        public static new string[] Attributes { get; } = new[] { "latencyInfo" };
        public static new bool ShouldLog { get; } = false;
    }
} 