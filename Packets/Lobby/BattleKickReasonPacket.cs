using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Lobby
{
    /// <summary>
    /// Reason why player was kicked from battle
    /// </summary>
    public class BattleKickReasonPacket : AbstractPacket
    {
        public static new int Id { get; } = -322235316;
        public static new string Description { get; } = "Reason why player was kicked from battle";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "reason" };
    }
} 