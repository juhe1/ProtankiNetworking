using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Loads limited info about a newly created battle
    /// </summary>
    public class BattleCreatedPacket : AbstractPacket
    {
        public static new int Id { get; } = 802300608;
        public static new string Description { get; } = "Loads limited info about a newly created battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 