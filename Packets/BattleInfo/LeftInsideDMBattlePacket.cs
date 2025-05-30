using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// A player has left a DM battle, the observer being within the battle
    /// </summary>
    public class LeftInsideDMBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -1689876764;
        public static new string Description { get; } = "A player has left a DM battle, the observer being within the battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 