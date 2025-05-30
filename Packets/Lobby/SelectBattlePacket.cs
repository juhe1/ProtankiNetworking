using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Client selects a battle / Server confirms selection of battle
    /// </summary>
    public class SelectBattlePacket : AbstractPacket
    {
        public static new int Id { get; } = 2092412133;
        public static new string Description { get; } = "Client selects a battle / Server confirms selection of battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleID" };
    }
} 