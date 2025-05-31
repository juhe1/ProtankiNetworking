using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network
{
    /// <summary>
    /// Ping Packet from server
    /// </summary>
    public class Ping : AbstractPacket
    {
        public static new int Id { get; } = -555602629;
        public static new string Description { get; } = "Ping Packet from server";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
