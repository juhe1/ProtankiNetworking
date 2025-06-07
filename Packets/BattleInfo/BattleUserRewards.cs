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
        public static int Id { get; } = 560336625;
        public override string Description => "Battle User Rewards";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(BattleUserRewardsCodec.Instance, false),
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "reward",
            "timeToRestart",
        };
    }
}
