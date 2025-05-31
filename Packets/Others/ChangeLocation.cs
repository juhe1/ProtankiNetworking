using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Buy from shop
    /// </summary>
    public class ChangeLocation : AbstractPacket
    {
        public static new int Id { get; } = 921004371;
        public static new string Description { get; } = "Buy from shop";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "location_abbreviation",
        };
    }
}
