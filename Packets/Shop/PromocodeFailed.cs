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
        public static new int Id { get; } = -1850050333;
        public static new string Description { get; } = "Incorrect or expired promocode";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
