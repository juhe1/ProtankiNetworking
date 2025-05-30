using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Load Bonus Box Resources
    /// </summary>
    public class UserSuppliesInfoPacket : AbstractPacket
    {
        public static new int Id { get; } = -137249251;
        public static new string Description { get; } = "Load Bonus Box Resources";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 