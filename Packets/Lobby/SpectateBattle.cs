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
        public static new int Id { get; } = -1315002220;
        public static new string Description { get; } = "Client requests to spectate the selected battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
