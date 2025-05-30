using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Others
{
    /// <summary>
    /// Get the id of the last battle you selected
    /// </summary>
    public class LastBattleIdPacket : AbstractPacket
    {
        public static new int Id { get; } = -602527073;
        public static new string Description { get; } = "Get the id of the last battle you selected";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "battleId" };
    }
} 