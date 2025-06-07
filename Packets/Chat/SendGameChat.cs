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
        public static int Id { get; } = 945463181;
        public override string Description => "Sends a message to the game chat";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "message",
            "teamOnly",
        };
    }
}
