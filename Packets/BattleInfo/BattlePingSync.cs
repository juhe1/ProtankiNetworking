using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Attempts to sync ping information with the server
    /// </summary>
    public class BattlePingSync : AbstractPacket
    {
        public static new int Id { get; } = 2074243318;
        public static new string Description { get; } = "Attempts to sync ping information with the server";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            DoubleIntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "latencyInfo",
        };
    }
}
