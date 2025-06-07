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
        public static int Id { get; } = -523392052;
        public override string Description => "Buy a kit";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "item_id",
            "base_cost",
        };
    }
}
