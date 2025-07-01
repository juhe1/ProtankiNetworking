using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Close settings modal
    /// </summary>
    public class CloseSettings : AbstractPacket
    {
        public static int Id { get; } = -731115522;
        public override string Description => "Close settings modal";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BoolCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "close_state",
        };
    }
}
