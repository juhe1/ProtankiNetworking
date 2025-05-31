using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Server tells us what resources to load
    /// </summary>
    public class LoadResources : AbstractPacket
    {
        public static new int Id { get; } = -1797047325;
        public static new string Description { get; } = "Server tells us what resources to load";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            JsonCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "json",
            "callbackID",
        };
    }
}
