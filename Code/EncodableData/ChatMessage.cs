using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class ChatMessage : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public UserStatus? SourceUser { get; set; }

	[Encode(1)]
	public bool System { get; set; }

	[Encode(2)]
	public UserStatus? TargetUser { get; set; }

	[Encode(3)]
	public string? Text { get; set; }

	[Encode(4)]
	public bool Warning { get; set; }
}
