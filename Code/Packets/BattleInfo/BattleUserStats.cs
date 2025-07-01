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
        public static int Id { get; } = 1061006142;
        public override string Description => "Battle User Stats";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(BattleUserStatsCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "usersStat",
        };
    }
}
