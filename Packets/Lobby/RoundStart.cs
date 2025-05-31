using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Starts a new round in the existing battle
    /// </summary>
    public class RoundStart : AbstractPacket
    {
        public static new int Id { get; } = -344514517;
        public static new string Description { get; } = "Starts a new round in the existing battle";
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
