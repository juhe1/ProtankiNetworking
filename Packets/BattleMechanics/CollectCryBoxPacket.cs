using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Collect a crystal box
    /// </summary>
    public class CollectCryBoxPacket : AbstractPacket
    {
        public static new int Id { get; } = -1047185003;
        public static new string Description { get; } = "Collect a crystal box";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "bonusId" };
    }
} 