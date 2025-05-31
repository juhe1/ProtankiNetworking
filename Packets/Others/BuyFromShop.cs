using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Change location in shop
    /// </summary>
    public class BuyFromShop : AbstractPacket
    {
        public static new int Id { get; } = 880756819;
        public static new string Description { get; } = "Change location in shop";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "itemId",
            "itemType",
        };
    }
}
