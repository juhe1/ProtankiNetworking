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
        public static int Id { get; } = -511004908;
        public override string Description => "Client uses a promocode";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "promocode",
        };
    }
}
