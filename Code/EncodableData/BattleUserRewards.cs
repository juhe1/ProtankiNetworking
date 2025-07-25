using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class BattleUserRewards : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public int NewbiesAbonementBonusReward { get; set; }

    [Encode(1)]
    public int PremiumBonusReward { get; set; }

    [Encode(2)]
    public int Reward { get; set; }

    [Encode(3)]
    public string? Userid { get; set; }

}