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
        public static int Id { get; } = -838186985;
        public override string Description => "Information about all maps the client should load";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "json",
        };
    }
}
