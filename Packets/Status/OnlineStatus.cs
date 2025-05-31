using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Status
{
    /// <summary>
    /// Updates Player's Online Status
    /// </summary>
    public class OnlineStatus : AbstractPacket
    {
        public static new int Id { get; } = 2041598093;
        public static new string Description { get; } = "Updates Player's Online Status";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            BoolCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "online",
            "serverID",
            "username",
        };
    }
}
