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
        public static int Id { get; } = 2041598093;
        public override string Description => "Updates Player's Online Status";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BoolCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "online",
            "serverID",
            "username",
        };
    }
}
