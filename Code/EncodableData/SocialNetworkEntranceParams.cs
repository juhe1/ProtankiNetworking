using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class SocialNetworkEntranceParams : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public string? AuthorizationUrl { get; set; }

    [Encode(1)]
    public string? SnId { get; set; }

}