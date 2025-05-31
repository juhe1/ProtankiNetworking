using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Battle User Stats
    /// </summary>
    public class BattleUserStats : AbstractPacket
    {
        public static new int Id { get; } = 1061006142;
        public static new string Description { get; } = "Battle User Stats";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(BattleUserStatsCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "usersStat",
        };
    }
}
