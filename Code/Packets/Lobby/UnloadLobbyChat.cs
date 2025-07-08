using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Packet to unload the lobby chat.
    /// </summary>
    public class UnloadLobbyChat : AbstractPacket
    {
        public static int Id { get; } = -920985123;
        public override string Description => "Unload the lobby chat";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {
        };
    }
} 