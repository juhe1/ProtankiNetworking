using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Sends a self destruct request to the server
    /// </summary>
    public class SelfDestruct : AbstractPacket
    {
        public static new int Id { get; } = 988664577;
        public static new string Description { get; } = "Sends a self destruct request to the server";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
