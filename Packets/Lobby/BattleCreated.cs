using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Loads limited info about a newly created battle
    /// </summary>
    public class BattleCreated : AbstractPacket
    {
        public static new int Id { get; } = 802300608;
        public static new string Description { get; } = "Loads limited info about a newly created battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "json",
        };
    }
}
