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
        public static int Id { get; } = -1505530736;
        public override string Description => "Mount an item in garage";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "item_id",
        };
    }
}
