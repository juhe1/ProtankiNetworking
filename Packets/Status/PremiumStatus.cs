using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Status
{
    /// <summary>
    /// Updates a player's premium status
    /// </summary>
    public class PremiumStatus : AbstractPacket
    {
        public static new int Id { get; } = -2069508071;
        public static new string Description { get; } = "Updates a player's premium status";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "timeLeft",
            "username",
        };
    }
}
