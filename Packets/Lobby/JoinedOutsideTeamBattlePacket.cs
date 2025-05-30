using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins a global Team battle, outside from the observer's perspective.
    /// </summary>
    public class JoinedOutsideTeamBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -169305322;
        public static new string Description { get; } = "Sent when a player joins a global Team battle, outside from the observer's perspective.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "username", "team" };
        public static new bool ShouldLog { get; } = false;
    }
} 