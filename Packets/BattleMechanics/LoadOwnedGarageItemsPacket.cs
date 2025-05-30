using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Load Owned Garage Items
    /// </summary>
    public class LoadOwnedGarageItemsPacket : AbstractPacket
    {
        public static new int Id { get; } = -255516505;
        public static new string Description { get; } = "Load Owned Garage Items";
        public static new Type[] CodecTypes { get; } = new[] { typeof(JsonCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 