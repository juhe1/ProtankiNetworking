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
        public static int Id { get; } = 880756819;
        public override string Description => "Change location in shop";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "itemId",
            "itemType",
        };
    }
}
