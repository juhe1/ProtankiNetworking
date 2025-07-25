using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class MissionStreak : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public int Level { get; set; }

    [Encode(1)]
    public int Streak { get; set; }

    [Encode(2)]
    public bool DoneToday { get; set; }

    [Encode(3)]
    public int QuestImgID { get; set; }

    [Encode(4)]
    public int RewardImgID { get; set; }

}