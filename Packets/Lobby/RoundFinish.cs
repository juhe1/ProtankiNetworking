using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// The existing battle round has finished
    /// </summary>
    public class RoundFinish : AbstractPacket
    {
        public static new int Id { get; } = 1534651002;
        public static new string Description { get; } = "The existing battle round has finished";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
        };
    }
}
