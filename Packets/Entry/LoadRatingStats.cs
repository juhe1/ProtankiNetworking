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
        public static int Id { get; } = -1128606444;
        public override string Description => "Player Rating stats";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            FloatCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "rating",
            "place",
        };
    }
}
