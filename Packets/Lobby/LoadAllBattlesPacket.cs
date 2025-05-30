using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Loads all current battles
    /// </summary>
    public class LoadAllBattlesPacket : AbstractPacket
    {
        public static new int Id { get; } = 552006706;
        public static new string Description { get; } = "Loads all current battles";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
        public static new string[] Attributes { get; } = new[] { "battlesJson" };
    }
} 