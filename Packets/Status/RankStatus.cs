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
        public static new int Id { get; } = -962759489;
        public static new string Description { get; } = "Loads the rank of a player";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "rank",
            "username",
        };
    }
}
