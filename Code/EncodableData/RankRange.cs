using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class RankRange : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public int MaxRank { get; set; }

    [Encode(1)]
    public int MinRank { get; set; }

}