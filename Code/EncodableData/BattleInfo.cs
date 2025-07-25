using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BattleInfo : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public string? BattleID { get; set; }

    [Encode(1)]
    public string? MapName { get; set; }

    [Encode(2)]
    public int Mode { get; set; }

    [Encode(3)]
    public bool Private { get; set; }

    [Encode(4)]
    public bool ProBattle { get; set; }

    [Encode(5)]
    public RankRange? Range { get; set; }

    [Encode(6)]
    public int ServerNumber { get; set; }

}