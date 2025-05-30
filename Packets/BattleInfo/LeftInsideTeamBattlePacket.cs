using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// A player has left a team battle, the observer being within the battle
    /// </summary>
    public class LeftInsideTeamBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = 1411656080;
        public static new string Description { get; } = "A player has left a team battle, the observer being within the battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "username" };
    }
} 