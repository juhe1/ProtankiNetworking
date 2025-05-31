using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// A mission was completed and is available to claim
    /// </summary>
    public class CompletedMission : AbstractPacket
    {
        public static new int Id { get; } = 1579425801;
        public static new string Description { get; } = "A mission was completed and is available to claim";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
