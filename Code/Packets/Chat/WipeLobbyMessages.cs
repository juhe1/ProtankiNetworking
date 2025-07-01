using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Chat
{
    /// <summary>
    /// Wipes all messages by a user in the lobby
    /// </summary>
    public class WipeLobbyMessages : AbstractPacket
    {
        public static int Id { get; } = 1993050216;
        public override string Description => "Wipes all messages by a user in the lobby";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
        };
    }
}
