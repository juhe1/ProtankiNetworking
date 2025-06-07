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
        public static int Id { get; } = -1797047325;
        public override string Description => "Server tells us what resources to load";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            JsonCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "json",
            "callbackID",
        };
    }
}
