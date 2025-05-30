using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Censors invalid battle names
    /// </summary>
    public class CheckBattleNamePacket : AbstractPacket
    {
        public static new int Id { get; } = 566652736;
        public static new string Description { get; } = "Censors invalid battle names";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleName" };
    }
} 