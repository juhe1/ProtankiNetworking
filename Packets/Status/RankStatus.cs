using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Status
{
    /// <summary>
    /// Loads the rank of a player
    /// </summary>
    public class RankStatus : AbstractPacket
    {
        public static int Id { get; } = -962759489;
        public override string Description => "Loads the rank of a player";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "rank",
            "username",
        };
    }
}
