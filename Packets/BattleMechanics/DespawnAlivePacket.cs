using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Player despawns while alive
    /// </summary>
    public class DespawnAlivePacket : AbstractPacket
    {
        public static new int Id { get; } = 1719707347;
        public static new string Description { get; } = "Player despawns while alive";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 