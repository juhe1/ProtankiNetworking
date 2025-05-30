using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Remove this player from the friends count in team status
    /// </summary>
    public class LeftOutsideTeamBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = 1447204641;
        public static new string Description { get; } = "Remove this player from the friends count in team status";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "username" };
        public static new bool ShouldLog { get; } = false;
    }
} 