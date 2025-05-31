using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Information about the ping of the player.
    /// </summary>
    public class BattlePingInfo : AbstractPacket
    {
        public static new int Id { get; } = 34068208;
        public static new string Description { get; } = "Information about the ping of the player.";
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
