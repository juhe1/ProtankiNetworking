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
        public static new int Id { get; } = -82304134;
        public static new string Description { get; } = "Client callsback after finishes resource loading (NOT IMPLEMENTED)";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "callbackId",
        };
    }
}
