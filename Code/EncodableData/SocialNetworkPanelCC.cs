using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class SocialNetworkPanelCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public bool PasswordCreated { get; set; }

	[Encode(1)]
	public SocialNetworkPanelParams?[]? SocialNetworkParams { get; set; }

}
