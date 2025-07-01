using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Client callsback after finishes resource loading (NOT IMPLEMENTED)
    /// </summary>
    public class ResourcesLoaded : AbstractPacket
    {
        public static int Id { get; } = -82304134;
        public override string Description => "Client callsback after finishes resource loading (NOT IMPLEMENTED)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "callbackId",
        };
    }
}
