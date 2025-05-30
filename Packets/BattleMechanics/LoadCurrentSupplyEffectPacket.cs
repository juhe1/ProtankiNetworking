using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Load Current Supply Effect
    /// </summary>
    public class LoadCurrentSupplyEffectPacket : AbstractPacket
    {
        public static new int Id { get; } = 417965410;
        public static new string Description { get; } = "Load Current Supply Effect";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 