using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Loads detailed battle information
    /// </summary>
    public class LoadBattleInfoPacket : AbstractPacket
    {
        public static new int Id { get; } = 546722394;
        public static new string Description { get; } = "Loads detailed battle information";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 