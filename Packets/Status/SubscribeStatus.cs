using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Status
{
    /// <summary>
    /// Subscribe to status updates of a player.
    /// </summary>
    public class SubscribeStatus : AbstractPacket
    {
        public static new int Id { get; } = 1774907609;
        public static new string Description { get; } = "Subscribe to status updates of a player.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
        };
    }
}
