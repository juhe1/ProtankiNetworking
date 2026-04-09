using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.EncodableData;

public class OnlineNotifierData : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public bool Online { get; set; }

	[Encode(1)]
	public int ServerNumber { get; set; }

	[Encode(2)]
	public string? UserId { get; set; }

}
