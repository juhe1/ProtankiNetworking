using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network
{
    /// <summary>
    /// Pong Packet from client
    /// </summary>
    public class Pong : AbstractPacket
    {
        public static new int Id { get; } = 1484572481;
        public static new string Description { get; } = "Pong Packet from client";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
