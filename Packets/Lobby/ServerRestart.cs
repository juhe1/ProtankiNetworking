using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Indicates time (in seconds) until server restart
    /// </summary>
    public class ServerRestart : AbstractPacket
    {
        public static new int Id { get; } = -1712113407;
        public static new string Description { get; } = "Indicates time (in seconds) until server restart";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "time",
        };
    }
}
