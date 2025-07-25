using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Battle User Stats
/// </summary>
public class BattleUserStats : Packet
{
    [Encode(0)]
    public BattleUserStatsData?[]? UsersStat { get; set; }

    public const int ID_CONST = 1061006142;
    public override int Id => ID_CONST;
    public override string Description => "Battle User Stats";


}