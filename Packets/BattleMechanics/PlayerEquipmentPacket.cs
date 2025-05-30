using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Player Equipment.
    /// </summary>
    public class PlayerEquipmentPacket : AbstractPacket
    {
        public static new int Id { get; } = -1643824092;
        public static new string Description { get; } = "Player Equipment.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 