using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Client requests to spectate the selected battle
    /// </summary>
    public class SpectateBattle : AbstractPacket
    {
        public static int Id { get; } = -1315002220;
        public override string Description => "Client requests to spectate the selected battle";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
