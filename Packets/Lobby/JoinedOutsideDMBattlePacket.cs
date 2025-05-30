using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins a global DM battle, outside from the observer's perspective.
    /// </summary>
    public class JoinedOutsideDMBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -2133657895;
        public static new string Description { get; } = "Sent when a player joins a global DM battle, outside from the observer's perspective.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID", "username" };
        public static new bool ShouldLog { get; } = false;
    }
} 