using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Chat
{
    /// <summary>
    /// Received a system message in the game chat
    /// </summary>
    public class ReceiveGameSystemChat : AbstractPacket
    {
        public static int Id { get; } = 606668848;
        public override string Description => "Received a system message in the game chat";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "message",
        };
    }
}
