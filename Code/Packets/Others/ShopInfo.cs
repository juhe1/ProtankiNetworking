using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Get shop info
    /// </summary>
    public class ShopInfo : AbstractPacket
    {
        public static int Id { get; } = 1863710730;
        public override string Description => "Get shop info";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "data",
        };
    }
}
