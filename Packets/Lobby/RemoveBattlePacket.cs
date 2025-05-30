using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Removes a battle from the lobby
    /// </summary>
    public class RemoveBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = -1848001147;
        public static new string Description { get; } = "Removes a battle from the lobby";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID" };
    }
} 