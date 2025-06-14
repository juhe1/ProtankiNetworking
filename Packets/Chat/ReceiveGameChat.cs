using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Chat
{
    /// <summary>
    /// Receives a message from the game chat
    /// </summary>
    public class ReceiveGameChat : AbstractPacket
    {
        public static int Id { get; } = 1259981343;
        public override string Description => "Receives a message from the game chat";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "message",
            "team",
        };
    }
}
