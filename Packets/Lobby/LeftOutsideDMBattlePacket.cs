using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// A player has left a DM battle, the observer being outside the battle
    /// </summary>
    public class LeftOutsideDMBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = 504016996;
        public static new string Description { get; } = "A player has left a DM battle, the observer being outside the battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "username" };
        public static new bool ShouldLog { get; } = false;
    }
} 