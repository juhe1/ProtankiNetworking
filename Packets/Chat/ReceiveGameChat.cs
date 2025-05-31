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
        public static new int Id { get; } = 1259981343;
        public static new string Description { get; } = "Receives a message from the game chat";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "message",
            "team",
        };
    }
}
