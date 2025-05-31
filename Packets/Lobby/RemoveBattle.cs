using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Removes a battle from the lobby
    /// </summary>
    public class RemoveBattle : AbstractPacket
    {
        public static new int Id { get; } = -1848001147;
        public static new string Description { get; } = "Removes a battle from the lobby";
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
