using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Garage
{
    /// <summary>
    /// If the mount was successful or not
    /// </summary>
    public class CheckItemMounted : AbstractPacket
    {
        public static new int Id { get; } = 2062201643;
        public static new string Description { get; } = "If the mount was successful or not";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "item_id",
            "mounted",
        };
    }
}
