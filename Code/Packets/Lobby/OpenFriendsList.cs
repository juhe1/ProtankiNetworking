using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Open Friends List
    /// </summary>
    public class OpenFriendsList : AbstractPacket
    {
        public static int Id { get; } = 1441234714;
        public override string Description => "Open Friends List";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
