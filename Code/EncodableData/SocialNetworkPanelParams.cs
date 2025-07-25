using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class SocialNetworkPanelParams : IEncodable
{
    public bool IsOptional { get; } = false;
    public bool IsArrayOptional { get; } = false;

    [Encode(0)]
    public string? AuthorizationUrl { get; set; }

    [Encode(1)]
    public bool LinkExists { get; set; }

    [Encode(2)]
    public string? SnId { get; set; }

}