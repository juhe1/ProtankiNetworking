using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Locations of existing bonus boxes
    /// </summary>
    public class BonusBoxExistingLocationsPacket : AbstractPacket
    {
        public static new int Id { get; } = 870278784;
        public static new string Description { get; } = "Locations of existing bonus boxes";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 