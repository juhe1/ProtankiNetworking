using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Shop
{
    /// <summary>
    /// Incorrect or expired promocode
    /// </summary>
    public class PromocodeFailed : AbstractPacket
    {
        public static int Id { get; } = -1850050333;
        public override string Description => "Incorrect or expired promocode";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
