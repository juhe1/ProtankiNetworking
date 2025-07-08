using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Updates the in-battle statistics of a player.
/// </summary>
public class UpdateBattlePlayerStatistics : AbstractPacket
{
    public static int IdStatic { get; } = 696140460;
    public override int Id => IdStatic;
    public override string Description => "Updates the in-battle statistics of a player.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        UserStatsCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "userStats"
    };
}