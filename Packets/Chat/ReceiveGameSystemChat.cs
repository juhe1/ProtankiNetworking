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
        public static new int Id { get; } = 606668848;
        public static new string Description { get; } = "Received a system message in the game chat";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "message",
        };
    }
}
