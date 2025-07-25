using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Loads current battle statistics
/// </summary>
public class InitBattleStats : Packet
{
    [Encode(0)]
    public int BattleMode { get; set; }

    [Encode(1)]
    public int Format { get; set; }

    [Encode(2)]
    public int Fund { get; set; }

    [Encode(3)]
    public BattleLimits? BattleLimits { get; set; }

    [Encode(4)]
    public string? MapName { get; set; }

    [Encode(5)]
    public int MaxPeopleCount { get; set; }

    [Encode(6)]
    public bool ParkourMode { get; set; }

    [Encode(7)]
    public int PremiumBonusPercentage { get; set; }

    [Encode(8)]
    public bool Spectator { get; set; }

    [Encode(9)]
    public string?[]? SuspiciousUsers { get; set; }

    [Encode(10)]
    public int TimeLeft { get; set; }

    public const int ID_CONST = 522993449;
    public override int Id => ID_CONST;
    public override string Description => "Loads current battle statistics";


}
