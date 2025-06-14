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
        public static int Id { get; } = -2069508071;
        public override string Description => "Updates a player's premium status";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "timeLeft",
            "username",
        };
    }
}
