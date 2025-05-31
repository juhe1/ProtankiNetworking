using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Changes client layout/mode
    /// </summary>
    public class ChangeLayout : AbstractPacket
    {
        public static new int Id { get; } = 1118835050;
        public static new string Description { get; } = "Changes client layout/mode";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "layout",
        };
    }
}
