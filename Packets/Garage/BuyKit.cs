using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Garage
{
    /// <summary>
    /// Buy a kit
    /// </summary>
    public class BuyKit : AbstractPacket
    {
        public static new int Id { get; } = -523392052;
        public static new string Description { get; } = "Buy a kit";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "item_id",
            "base_cost",
        };
    }
}
