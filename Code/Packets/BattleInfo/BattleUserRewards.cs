using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Battle User Rewards
/// </summary>
public class BattleUserRewards : AbstractPacket
{
    public const int IdStatic = 560336625;
    public override int Id => IdStatic;
    public override string Description => "Battle User Rewards";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(BattleUserRewardsCodec.Instance, false),
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "reward",
        "timeToRestart"
    };
}