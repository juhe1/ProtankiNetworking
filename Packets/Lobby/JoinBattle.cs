using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Client requests to join the selected battle
    /// </summary>
    public class JoinBattle : AbstractPacket
    {
        public static new int Id { get; } = -1284211503;
        public static new string Description { get; } = "Client requests to join the selected battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "team",
        };
    }
}
