using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Battle user stats
/// </summary>
public class BattleUserTeamStats : AbstractPacket
{
    public static int Id { get; } = -497293992;
    public override string Description => "Battle user stats";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        UserStatsCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "usersStat",
        "team"
    };
}