using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Garage
{
    /// <summary>
    /// Mount an item in garage
    /// </summary>
    public class MountItem : AbstractPacket
    {
        public static new int Id { get; } = -1505530736;
        public static new string Description { get; } = "Mount an item in garage";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "item_id",
        };
    }
}
