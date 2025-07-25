

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Loads the player's own account stats
/// </summary>
public class LoadAccountStats : Packet
{
    [Encode(0)]
    public int Crystals { get; set; }

    [Encode(1)]
    public int CurrentRankXP { get; set; }

    [Encode(2)]
    public int DoubleCrystalLength { get; set; }

    [Encode(3)]
    public bool HasDoubleCrystal { get; set; }

    [Encode(4)]
    public int NextRankXP { get; set; }

    [Encode(5)]
    public int RatingRank { get; set; }

    [Encode(6)]
    public byte Rank { get; set; }

    [Encode(7)]
    public float Rating { get; set; }

    [Encode(8)]
    public int XP { get; set; }

    [Encode(9)]
    public int ServerNumber { get; set; }

    [Encode(10)]
    public string? Username { get; set; }

    [Encode(11)]
    public string? UserProfileUrl { get; set; }

    public const int ID_CONST = 907073245;
    public override int Id => ID_CONST;
    public override string Description => "Loads the player's own account stats";


}