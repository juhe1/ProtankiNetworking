using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Creates a new battle
/// </summary>
public class CreateBattle : Packet
{
    [Encode(0)]
    public bool AutoBalance { get; set; }

    [Encode(1)]
    public int BattleMode { get; set; }

    [Encode(2)]
    public int Format { get; set; }

    [Encode(3)]
    public bool FriendlyFire { get; set; }

    [Encode(4)]
    public BattleLimits? BattleLimits { get; set; }

    [Encode(5)]
    public string? MapID { get; set; }

    [Encode(6)]
    public int MaxPeopleCount { get; set; }

    [Encode(7)]
    public string? Name { get; set; }

    [Encode(8)]
    public bool ParkourMode { get; set; }

    [Encode(9)]
    public bool PrivateBattle { get; set; }

    [Encode(10)]
    public bool ProBattle { get; set; }

    [Encode(11)]
    public RankRange? RankRange { get; set; }

    [Encode(12)]
    public bool NoRearm { get; set; }

    [Encode(13)]
    public int Theme { get; set; }

    [Encode(14)]
    public bool NoSupplyBoxes { get; set; }

    [Encode(15)]
    public bool NoCrystalBoxes { get; set; }

    [Encode(16)]
    public bool NoSupplies { get; set; }

    [Encode(17)]
    public bool NoUpgrade { get; set; }

    [Encode(18)]
    public bool LowResistance { get; set; }

    [Encode(19)]
    public bool UseDropTimings { get; set; }

    [Encode(20)]
    public bool NoGoldBoxes { get; set; }

    [Encode(21)]
    public bool NoGoldSiren { get; set; }

    [Encode(22)]
    public bool NoGoldDropZone { get; set; }

    [Encode(23)]
    public bool NoMedkit { get; set; }

    [Encode(24)]
    public bool NoMines { get; set; }

    [Encode(25)]
    public bool RandomGoldChance { get; set; }

    [Encode(26)]
    public bool DependentCooldown { get; set; }

    public const int ID_CONST = -2135234426;
    public override int Id => ID_CONST;
    public override string Description => "Creates a new battle";


}