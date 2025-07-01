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
        public static int Id { get; } = 921004371;
        public override string Description => "Buy from shop";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "location_abbreviation",
        };
    }
}
