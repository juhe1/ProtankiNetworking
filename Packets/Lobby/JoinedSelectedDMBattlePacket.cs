using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins the currently-selected DM battle.
    /// </summary>
    public class JoinedSelectedDMBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -911626491;
        public static new string Description { get; } = "Sent when a player joins the currently-selected DM battle.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(BattleInfoUserCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "userInfo" };
        public static new bool ShouldLog { get; } = false;
    }
} 