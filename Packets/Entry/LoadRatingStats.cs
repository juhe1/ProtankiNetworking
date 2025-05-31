using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Player Rating stats
    /// </summary>
    public class LoadRatingStats : AbstractPacket
    {
        public static new int Id { get; } = -1128606444;
        public static new string Description { get; } = "Player Rating stats";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            FloatCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "rating",
            "place",
        };
    }
}
