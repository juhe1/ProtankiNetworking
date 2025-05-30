using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// User Changed Equipment
    /// </summary>
    public class ChangedEquipmentPacket : AbstractPacket
    {
        public static new int Id { get; } = -1767633906;
        public static new string Description { get; } = "User Changed Equipment";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "tank" };
    }
} 