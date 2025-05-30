using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.Status
{
    /// <summary>
    /// Sets the battle status of the player to the battle ID
    /// </summary>
    public class InBattleStatusPacket : AbstractPacket
    {
        public static new int Id { get; } = -1895446889;
        public static new string Description { get; } = "Sets the battle status of the player to the battle ID";
        public static new Type[] CodecTypes { get; } = new[] { typeof(BattleNotifierCodec) };
        public static new string[] Attributes { get; } = new[] { "battleNotifier" };
        public static new bool ShouldLog { get; } = false;
    }
} 