using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Loads all current battles
    /// </summary>
    public class LoadAllBattles : AbstractPacket
    {
        public static new int Id { get; } = 552006706;
        public static new string Description { get; } = "Loads all current battles";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            JsonCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battlesJson",
        };
    }
}
