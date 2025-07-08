using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Packet for updating typing antiflood parameters.
    /// </summary>
    public class UpdateTypingAntifloodParams : AbstractPacket
    {
        public static int Id { get; } = 744948472;
        public override string Description => "Update typing antiflood parameters";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // symbolCost
            IntCodec.Instance, // messageCost
        };
        public override string[] Attributes => new string[]
        {
            "symbolCost",
            "messageCost",
        };
    }
} 