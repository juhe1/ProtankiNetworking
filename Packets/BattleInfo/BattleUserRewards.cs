using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Battle User Rewards
    /// </summary>
    public class BattleUserRewards : AbstractPacket
    {
        public static new int Id { get; } = 560336625;
        public static new string Description { get; } = "Battle User Rewards";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(BattleUserRewardsCodec.Instance, false),
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "reward",
            "timeToRestart",
        };
    }
}
