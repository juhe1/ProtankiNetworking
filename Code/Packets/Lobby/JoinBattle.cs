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
        public static int Id { get; } = -1284211503;
        public override string Description => "Client requests to join the selected battle";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "team",
        };
    }
}
