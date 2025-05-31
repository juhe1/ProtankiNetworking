using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Load Purchasable Items
    /// </summary>
    public class LoadPurchasableItems : AbstractPacket
    {
        public static new int Id { get; } = -300370823;
        public static new string Description { get; } = "Load Purchasable Items";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "json",
        };
    }
}
