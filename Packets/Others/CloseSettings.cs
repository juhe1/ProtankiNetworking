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
        public static new int Id { get; } = -731115522;
        public static new string Description { get; } = "Close settings modal";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "close_state",
        };
    }
}
