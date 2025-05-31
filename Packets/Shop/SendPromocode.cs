using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Shop
{
    /// <summary>
    /// Client uses a promocode
    /// </summary>
    public class SendPromocode : AbstractPacket
    {
        public static new int Id { get; } = -511004908;
        public static new string Description { get; } = "Client uses a promocode";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "promocode",
        };
    }
}
