using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Information about all maps the client should load
    /// </summary>
    public class LoadMapInfo : AbstractPacket
    {
        public static new int Id { get; } = -838186985;
        public static new string Description { get; } = "Information about all maps the client should load";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "json",
        };
    }
}
