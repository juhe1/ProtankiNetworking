using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Packet to unload the garage space.
    /// </summary>
    public class UnloadGarageSpace : AbstractPacket
    {
        public static int Id { get; } = 1211186637;
        public override string Description => "Unload the garage space";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {
        };
    }
} 