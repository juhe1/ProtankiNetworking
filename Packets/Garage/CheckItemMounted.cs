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
        public static int Id { get; } = 2062201643;
        public override string Description => "If the mount was successful or not";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "item_id",
            "mounted",
        };
    }
}
