using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Load Purchasable Items
    /// </summary>
    public class LoadPurchasableItemsPacket : AbstractPacket
    {
        public static new int Id { get; } = -300370823;
        public static new string Description { get; } = "Load Purchasable Items";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "json" };
    }
} 