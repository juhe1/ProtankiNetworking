using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Client requests to join the selected battle
    /// </summary>
    public class JoinBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -1284211503;
        public static new string Description { get; } = "Client requests to join the selected battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "team" };
    }
} 