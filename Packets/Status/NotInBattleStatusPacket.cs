using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Status
{
    /// <summary>
    /// Sets the player's battle status to not in battle
    /// </summary>
    public class NotInBattleStatusPacket : AbstractPacket
    {
        public static new int Id { get; } = 1941694508;
        public static new string Description { get; } = "Sets the player's battle status to not in battle";
        public static new string[] Attributes { get; } = new[] { "username" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new bool ShouldLog { get; } = false;
    }
} 