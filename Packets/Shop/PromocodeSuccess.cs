using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Shop
{
    /// <summary>
    /// Promocode applied successfully
    /// </summary>
    public class PromocodeSuccess : AbstractPacket
    {
        public static new int Id { get; } = -1859441081;
        public static new string Description { get; } = "Promocode applied successfully";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
