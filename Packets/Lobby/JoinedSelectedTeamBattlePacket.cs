using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins the currently-selected Team battle.
    /// </summary>
    public class JoinedSelectedTeamBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = 118447426;
        public static new string Description { get; } = "Sent when a player joins the currently-selected Team battle.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(BattleInfoUserCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "userInfo", "team" };
        public static new bool ShouldLog { get; } = false;
    }
} 