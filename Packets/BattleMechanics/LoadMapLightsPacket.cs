using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Load Map Lights
    /// </summary>
    public class LoadMapLightsPacket : AbstractPacket
    {
        public static new int Id { get; } = -152638117;
        public static new string Description { get; } = "Load Map Lights";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 