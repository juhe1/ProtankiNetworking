using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Chat
{
    /// <summary>
    /// Sends a message to the game chat
    /// </summary>
    public class SendGameChat : AbstractPacket
    {
        public static new int Id { get; } = 945463181;
        public static new string Description { get; } = "Sends a message to the game chat";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "message",
            "teamOnly",
        };
    }
}
