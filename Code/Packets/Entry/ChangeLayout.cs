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
        public static int Id { get; } = 1118835050;
        public override string Description => "Changes client layout/mode";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "layout",
        };
    }
}
